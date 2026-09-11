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
    [Guid("e9707e05-6d55-4636-b185-3de21210bd75")]
    [NativeName("Name", "IMFMediaKeySession2")]
    public unsafe partial struct IMFMediaKeySession2 : IComVtbl<IMFMediaKeySession2>, IComVtbl<IMFMediaKeySession>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e9707e05-6d55-4636-b185-3de21210bd75");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IMFMediaKeySession(IMFMediaKeySession2 val)
            => Unsafe.As<IMFMediaKeySession2, IMFMediaKeySession>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeySession2 val)
            => Unsafe.As<IMFMediaKeySession2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeySession2
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
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ushort* code, uint* systemCode)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ushort* code, ref uint systemCode)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* systemCodePtr = &systemCode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ref ushort code, uint* systemCode)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* codePtr = &code)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetError(ref ushort code, ref uint systemCode)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* codePtr = &code)
            {
                fixed (uint* systemCodePtr = &systemCode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(char** keySystem)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(ref char* keySystem)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionId(char** sessionId)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[5])(@this, sessionId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionId(ref char* sessionId)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** sessionIdPtr = &sessionId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char**, int>)@this->LpVtbl[5])(@this, sessionIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, key, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* keyPtr = &key)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
            SilkMarshal.Free((nint)keyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, uint* puSize)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArray, puSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeyStatuses(MFMediaKeyStatus** pKeyStatusesArray, ref uint puSize)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puSizePtr = &puSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArray, puSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeyStatuses(ref MFMediaKeyStatus* pKeyStatusesArray, uint* puSize)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MFMediaKeyStatus** pKeyStatusesArrayPtr = &pKeyStatusesArray)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArrayPtr, puSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeyStatuses(ref MFMediaKeyStatus* pKeyStatusesArray, ref uint puSize)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MFMediaKeyStatus** pKeyStatusesArrayPtr = &pKeyStatusesArray)
            {
                fixed (uint* puSizePtr = &puSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, MFMediaKeyStatus**, uint*, int>)@this->LpVtbl[8])(@this, pKeyStatusesArrayPtr, puSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(char* bstrSessionId, int* pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionId, pfLoaded);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(char* bstrSessionId, ref int pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfLoadedPtr = &pfLoaded)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionId, pfLoadedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(ref char bstrSessionId, int* pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrSessionIdPtr = &bstrSessionId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoaded);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref char bstrSessionId, ref int pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrSessionIdPtr = &bstrSessionId)
            {
                fixed (int* pfLoadedPtr = &pfLoaded)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoadedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrSessionId, int* pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrSessionIdPtr = (byte*) SilkMarshal.StringToPtr(bstrSessionId, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoaded);
            SilkMarshal.Free((nint)bstrSessionIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrSessionId, ref int pfLoaded)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrSessionIdPtr = (byte*) SilkMarshal.StringToPtr(bstrSessionId, NativeStringEncoding.BStr);
            fixed (int* pfLoadedPtr = &pfLoaded)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, int*, int>)@this->LpVtbl[9])(@this, bstrSessionIdPtr, pfLoadedPtr);
            }
            SilkMarshal.Free((nint)bstrSessionIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateRequest(char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitData, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateRequest(char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitDataPtr, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateRequest(char* initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataType, pbInitDataPtr, cb);
            SilkMarshal.Free((nint)pbInitDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateRequest(ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* initDataTypePtr = &initDataType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitData, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GenerateRequest(ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* initDataTypePtr = &initDataType)
            {
                fixed (byte* pbInitDataPtr = &pbInitData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GenerateRequest(ref char initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* initDataTypePtr = &initDataType)
            {
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, char*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
            SilkMarshal.Free((nint)pbInitDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateRequest([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitData, cb);
            SilkMarshal.Free((nint)initDataTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GenerateRequest([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
            fixed (byte* pbInitDataPtr = &pbInitData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
            }
            SilkMarshal.Free((nint)initDataTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GenerateRequest([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string initDataType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbInitData, uint cb)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var initDataTypePtr = (byte*) SilkMarshal.StringToPtr(initDataType, NativeStringEncoding.BStr);
            var pbInitDataPtr = (byte*) SilkMarshal.StringToPtr(pbInitData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, byte*, byte*, uint, int>)@this->LpVtbl[10])(@this, initDataTypePtr, pbInitDataPtr, cb);
            SilkMarshal.Free((nint)pbInitDataPtr);
            SilkMarshal.Free((nint)initDataTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExpiration(double* dblExpiration)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, double*, int>)@this->LpVtbl[11])(@this, dblExpiration);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetExpiration(ref double dblExpiration)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* dblExpirationPtr = &dblExpiration)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, double*, int>)@this->LpVtbl[11])(@this, dblExpirationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Remove()
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Shutdown()
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession2*, int>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(string[] keySystemSa)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var keySystem = (char**) SilkMarshal.StringArrayToPtr(keySystemSa);
            var ret = @this->GetKeySystem(keySystem);
            SilkMarshal.CopyPtrToStringArray((nint) keySystem, keySystemSa);
            SilkMarshal.Free((nint) keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSessionId(string[] sessionIdSa)
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var sessionId = (char**) SilkMarshal.StringArrayToPtr(sessionIdSa);
            var ret = @this->GetSessionId(sessionId);
            SilkMarshal.CopyPtrToStringArray((nint) sessionId, sessionIdSa);
            SilkMarshal.Free((nint) sessionId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySession2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
