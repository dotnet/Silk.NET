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
    [Guid("fbe256c1-43cf-4a9b-8cb8-ce8632a34186")]
    [NativeName("Name", "IMFMediaEngineClassFactory4")]
    public unsafe partial struct IMFMediaEngineClassFactory4 : IComVtbl<IMFMediaEngineClassFactory4>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fbe256c1-43cf-4a9b-8cb8-ce8632a34186");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineClassFactory4 val)
            => Unsafe.As<IMFMediaEngineClassFactory4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineClassFactory4
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
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Guid* riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObject);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObjectPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObject);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObjectPtr);
                }
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->CreateContentDecryptionModuleFactory(keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->CreateContentDecryptionModuleFactory(in keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->CreateContentDecryptionModuleFactory(keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(keySystem, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(in keySystem, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(keySystem, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
