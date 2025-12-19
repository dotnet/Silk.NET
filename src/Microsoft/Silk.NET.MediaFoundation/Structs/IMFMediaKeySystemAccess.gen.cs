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

namespace Silk.NET.MediaFoundation
{
    [Guid("aec63fda-7a97-4944-b35c-6c6df8085cc3")]
    [NativeName("Name", "IMFMediaKeySystemAccess")]
    public unsafe partial struct IMFMediaKeySystemAccess : IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("aec63fda-7a97-4944-b35c-6c6df8085cc3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeySystemAccess val)
            => Unsafe.As<IMFMediaKeySystemAccess, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeySystemAccess
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
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(IPropertyStore* pCdmCustomConfig, IMFMediaKeys2** ppKeys)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfig, ppKeys);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(IPropertyStore* pCdmCustomConfig, ref IMFMediaKeys2* ppKeys)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeys2** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfig, ppKeysPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref IPropertyStore pCdmCustomConfig, IMFMediaKeys2** ppKeys)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStore* pCdmCustomConfigPtr = &pCdmCustomConfig)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfigPtr, ppKeys);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref IPropertyStore pCdmCustomConfig, ref IMFMediaKeys2* ppKeys)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStore* pCdmCustomConfigPtr = &pCdmCustomConfig)
            {
                fixed (IMFMediaKeys2** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore*, IMFMediaKeys2**, int>)@this->LpVtbl[3])(@this, pCdmCustomConfigPtr, ppKeysPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSupportedConfiguration(IPropertyStore** ppSupportedConfiguration)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore**, int>)@this->LpVtbl[4])(@this, ppSupportedConfiguration);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSupportedConfiguration(ref IPropertyStore* ppSupportedConfiguration)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStore** ppSupportedConfigurationPtr = &ppSupportedConfiguration)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, IPropertyStore**, int>)@this->LpVtbl[4])(@this, ppSupportedConfigurationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(char** pKeySystem)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, char**, int>)@this->LpVtbl[5])(@this, pKeySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(ref char* pKeySystem)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pKeySystemPtr = &pKeySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySystemAccess*, char**, int>)@this->LpVtbl[5])(@this, pKeySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>(IPropertyStore* pCdmCustomConfig, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys2>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(pCdmCustomConfig, (IMFMediaKeys2**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaKeys<TI0>(ref IPropertyStore pCdmCustomConfig, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys2>, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(ref pCdmCustomConfig, (IMFMediaKeys2**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(string[] pKeySystemSa)
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pKeySystem = (char**) SilkMarshal.StringArrayToPtr(pKeySystemSa);
            var ret = @this->GetKeySystem(pKeySystem);
            SilkMarshal.CopyPtrToStringArray((nint) pKeySystem, pKeySystemSa);
            SilkMarshal.Free((nint) pKeySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySystemAccess*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
