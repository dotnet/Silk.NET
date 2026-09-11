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
    [Guid("3787614f-65f7-4003-b673-ead8293a0e60")]
    [NativeName("Name", "IMFMediaEngineClassFactory3")]
    public unsafe partial struct IMFMediaEngineClassFactory3 : IComVtbl<IMFMediaEngineClassFactory3>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3787614f-65f7-4003-b673-ead8293a0e60");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineClassFactory3 val)
            => Unsafe.As<IMFMediaEngineClassFactory3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineClassFactory3
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
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystem, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess(ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
                {
                    fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, char*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArray, uSize, ppKeyAccessPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccess);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref IMFMediaKeySystemAccess* ppKeyAccess)
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (IPropertyStore** ppSupportedConfigurationsArrayPtr = &ppSupportedConfigurationsArray)
            {
                fixed (IMFMediaKeySystemAccess** ppKeyAccessPtr = &ppKeyAccess)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory3*, byte*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)@this->LpVtbl[3])(@this, keySystemPtr, ppSupportedConfigurationsArrayPtr, uSize, ppKeyAccessPtr);
                }
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>(char* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>(char* keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>(ref char keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(ref keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>(ref char keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(ref keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(keySystem, ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeySystemAccess<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref IPropertyStore* ppSupportedConfigurationsArray, uint uSize, ref ComPtr<TI0> ppKeyAccess) where TI0 : unmanaged, IComVtbl<IMFMediaKeySystemAccess>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeySystemAccess(keySystem, ref ppSupportedConfigurationsArray, uSize, (IMFMediaKeySystemAccess**) ppKeyAccess.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
