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

namespace Silk.NET.Direct3D12
{
    [Guid("8aaf9303-ad25-48b9-9a57-d9c37e009d9f")]
    [NativeName("Name", "ID3D12SDKConfiguration1")]
    public unsafe partial struct ID3D12SDKConfiguration1 : IComVtbl<ID3D12SDKConfiguration1>, IComVtbl<ID3D12SDKConfiguration>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8aaf9303-ad25-48b9-9a57-d9c37e009d9f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12SDKConfiguration(ID3D12SDKConfiguration1 val)
            => Unsafe.As<ID3D12SDKConfiguration1, ID3D12SDKConfiguration>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12SDKConfiguration1 val)
            => Unsafe.As<ID3D12SDKConfiguration1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12SDKConfiguration1
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
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSDKVersion(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSDKVersion(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSDKVersion(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, int>)@this->LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Guid* riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riid, ppvFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, Guid* riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvFactoryPtr = &ppvFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riid, ppvFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, ref Guid riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riidPtr, ppvFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, ref Guid riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvFactoryPtr = &ppvFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPath, riidPtr, ppvFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, Guid* riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, Guid* riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
                fixed (void** ppvFactoryPtr = &ppvFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, ref Guid riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactory);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, ref Guid riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvFactoryPtr = &ppvFactory)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactoryPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Guid* riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactory);
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, Guid* riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            fixed (void** ppvFactoryPtr = &ppvFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riid, ppvFactoryPtr);
            }
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, ref Guid riid, void** ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactory);
            }
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, ref Guid riid, ref void* ppvFactory)
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvFactoryPtr = &ppvFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, SDKVersion, SDKPathPtr, riidPtr, ppvFactoryPtr);
                }
            }
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void FreeUnusedSDKs()
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration1*, void>)@this->LpVtbl[5])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvFactory = default;
            return @this->CreateDeviceFactory(SDKVersion, SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvFactory = default;
            return @this->CreateDeviceFactory(SDKVersion, in SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath, out ComPtr<TI0> ppvFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvFactory = default;
            return @this->CreateDeviceFactory(SDKVersion, SDKPath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, SDKPath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, in SDKPath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDeviceFactory<TI0>(uint SDKVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12SDKConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDeviceFactory(SDKVersion, SDKPath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
