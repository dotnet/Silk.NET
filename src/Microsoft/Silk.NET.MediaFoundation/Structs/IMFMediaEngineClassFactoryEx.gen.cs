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
    [Guid("c56156c6-ea5b-48a5-9df8-fbe035d0929e")]
    [NativeName("Name", "IMFMediaEngineClassFactoryEx")]
    public unsafe partial struct IMFMediaEngineClassFactoryEx : IComVtbl<IMFMediaEngineClassFactoryEx>, IComVtbl<IMFMediaEngineClassFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c56156c6-ea5b-48a5-9df8-fbe035d0929e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaEngineClassFactory(IMFMediaEngineClassFactoryEx val)
            => Unsafe.As<IMFMediaEngineClassFactoryEx, IMFMediaEngineClassFactory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineClassFactoryEx val)
            => Unsafe.As<IMFMediaEngineClassFactoryEx, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineClassFactoryEx
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
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, IMFAttributes* pAttr, ref IMFMediaEngine* ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttr, ppPlayerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, ref IMFAttributes pAttr, IMFMediaEngine** ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaEngine* ppPlayer)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                fixed (IMFMediaEngine** ppPlayerPtr = &ppPlayer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int>)@this->LpVtbl[3])(@this, dwFlags, pAttrPtr, ppPlayerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTimeRange(ref IMFMediaTimeRange* ppTimeRange)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppTimeRangePtr = &ppTimeRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppTimeRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateError(IMFMediaError** ppError)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateError(ref IMFMediaError* ppError)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaError** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int>)@this->LpVtbl[5])(@this, ppErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaSourceExtension(uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttr, ppMSE);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaSourceExtension(uint dwFlags, IMFAttributes* pAttr, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttr, ppMSEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaSourceExtension(uint dwFlags, ref IMFAttributes pAttr, IMFMediaSourceExtension** ppMSE)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttrPtr, ppMSE);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaSourceExtension(uint dwFlags, ref IMFAttributes pAttr, ref IMFMediaSourceExtension* ppMSE)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFAttributes* pAttrPtr = &pAttr)
            {
                fixed (IMFMediaSourceExtension** ppMSEPtr = &ppMSE)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int>)@this->LpVtbl[6])(@this, dwFlags, pAttrPtr, ppMSEPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePath, ppKeys);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePath, ppKeysPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeys);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeysPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeys);
            SilkMarshal.Free((nint)cdmStorePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystem, cdmStorePathPtr, ppKeysPtr);
            }
            SilkMarshal.Free((nint)cdmStorePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeys);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeysPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (char* cdmStorePathPtr = &cdmStorePath)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (char* cdmStorePathPtr = &cdmStorePath)
                {
                    fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
            SilkMarshal.Free((nint)cdmStorePathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys(ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
                }
            SilkMarshal.Free((nint)cdmStorePathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeys);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePath, ppKeysPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (char* cdmStorePathPtr = &cdmStorePath)
            {
                fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
                }
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, IMFMediaKeys** ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeys);
            SilkMarshal.Free((nint)cdmStorePathPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref IMFMediaKeys* ppKeys)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            var cdmStorePathPtr = (byte*) SilkMarshal.StringToPtr(cdmStorePath, NativeStringEncoding.BStr);
            fixed (IMFMediaKeys** ppKeysPtr = &ppKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, IMFMediaKeys**, int>)@this->LpVtbl[7])(@this, keySystemPtr, cdmStorePathPtr, ppKeysPtr);
            }
            SilkMarshal.Free((nint)cdmStorePathPtr);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, char* keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystem, isSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, char* keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystem, isSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, ref char keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, ref char keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (int* isSupportedPtr = &isSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupported);
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, type, keySystemPtr, isSupportedPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(ref char type, char* keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupported);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(ref char type, char* keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (int* isSupportedPtr = &isSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupportedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(ref char type, ref char keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupported(ref char type, ref char keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
                fixed (char* keySystemPtr = &keySystem)
                {
                    fixed (int* isSupportedPtr = &isSupported)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported(ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupported(ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* typePtr = &type)
            {
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
                fixed (int* isSupportedPtr = &isSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, char*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
                }
            SilkMarshal.Free((nint)keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupported);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystem, isSupportedPtr);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (int* isSupportedPtr = &isSupported)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, char*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
                }
            }
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, int* isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupported);
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTypeSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref int isSupported)
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
            var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (int* isSupportedPtr = &isSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactoryEx*, byte*, byte*, int*, int>)@this->LpVtbl[8])(@this, typePtr, keySystemPtr, isSupportedPtr);
            }
            SilkMarshal.Free((nint)keySystemPtr);
            SilkMarshal.Free((nint)typePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance<TI0>(uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance(dwFlags, pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0>(uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppPlayer) where TI0 : unmanaged, IComVtbl<IMFMediaEngine>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance(dwFlags, ref pAttr, (IMFMediaEngine**) ppPlayer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTimeRange<TI0>(ref ComPtr<TI0> ppTimeRange) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTimeRange((IMFMediaTimeRange**) ppTimeRange.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateError<TI0>(ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<IMFMediaError>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateError((IMFMediaError**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaSourceExtension<TI0>(uint dwFlags, IMFAttributes* pAttr, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaSourceExtension(dwFlags, pAttr, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaSourceExtension<TI0>(uint dwFlags, ref IMFAttributes pAttr, ref ComPtr<TI0> ppMSE) where TI0 : unmanaged, IComVtbl<IMFMediaSourceExtension>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaSourceExtension(dwFlags, ref pAttr, (IMFMediaSourceExtension**) ppMSE.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>(char* keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>(char* keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>(char* keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>(ref char keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(ref keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaKeys<TI0>(ref char keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(ref keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaKeys<TI0>(ref char keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(ref keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMediaKeys<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, char* cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaKeys<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref char cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, ref cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMediaKeys<TI0>([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string cdmStorePath, ref ComPtr<TI0> ppKeys) where TI0 : unmanaged, IComVtbl<IMFMediaKeys>, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMediaKeys(keySystem, cdmStorePath, (IMFMediaKeys**) ppKeys.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineClassFactoryEx*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
