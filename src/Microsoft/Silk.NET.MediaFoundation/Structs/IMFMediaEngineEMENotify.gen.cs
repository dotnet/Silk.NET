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
    [Guid("9e184d15-cdb7-4f86-b49e-566689f4a601")]
    [NativeName("Name", "IMFMediaEngineEMENotify")]
    public unsafe partial struct IMFMediaEngineEMENotify : IComVtbl<IMFMediaEngineEMENotify>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9e184d15-cdb7-4f86-b49e-566689f4a601");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineEMENotify val)
            => Unsafe.As<IMFMediaEngineEMENotify, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineEMENotify
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
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, char* bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataType);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, ref char bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataTypePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitData, cb, bstrInitDataTypePtr);
            SilkMarshal.Free((nint)bstrInitDataTypePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, char* bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataType);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, ref char bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
                fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
                {
                    ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
            var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
                ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
            SilkMarshal.Free((nint)bstrInitDataTypePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, char* bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataType);
            SilkMarshal.Free((nint)pbInitDataPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, ref char bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            fixed (char* bstrInitDataTypePtr = &bstrInitDataType)
            {
                ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, char*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
            }
            SilkMarshal.Free((nint)pbInitDataPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void Encrypted([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrInitDataType)
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            var bstrInitDataTypePtr = (byte*) SilkMarshal.StringToPtr(bstrInitDataType, NativeStringEncoding.BStr);
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, byte*, uint, byte*, void>)@this->LpVtbl[3])(@this, pbInitDataPtr, cb, bstrInitDataTypePtr);
            SilkMarshal.Free((nint)bstrInitDataTypePtr);
            SilkMarshal.Free((nint)pbInitDataPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void WaitingForKey()
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IMFMediaEngineEMENotify*, void>)@this->LpVtbl[4])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineEMENotify*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
