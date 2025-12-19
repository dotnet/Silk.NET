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
    [Guid("24fa67d5-d1d0-4dc5-995c-c0efdc191fb5")]
    [NativeName("Name", "IMFMediaKeySession")]
    public unsafe partial struct IMFMediaKeySession : IComVtbl<IMFMediaKeySession>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("24fa67d5-d1d0-4dc5-995c-c0efdc191fb5");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaKeySession val)
            => Unsafe.As<IMFMediaKeySession, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaKeySession
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
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ushort* code, uint* systemCode)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ushort* code, ref uint systemCode)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* systemCodePtr = &systemCode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, code, systemCodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetError(ref ushort code, uint* systemCode)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* codePtr = &code)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetError(ref ushort code, ref uint systemCode)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ushort* codePtr = &code)
            {
                fixed (uint* systemCodePtr = &systemCode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, ushort*, uint*, int>)@this->LpVtbl[3])(@this, codePtr, systemCodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(char** keySystem)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[4])(@this, keySystem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetKeySystem(ref char* keySystem)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[4])(@this, keySystemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionId(char** sessionId)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[5])(@this, sessionId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSessionId(ref char* sessionId)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** sessionIdPtr = &sessionId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, char**, int>)@this->LpVtbl[5])(@this, sessionIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, uint cb)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, key, cb);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, uint cb)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* keyPtr = &key)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, uint cb)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var keyPtr = (byte*) SilkMarshal.StringToPtr(key, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, byte*, uint, int>)@this->LpVtbl[6])(@this, keyPtr, cb);
            SilkMarshal.Free((nint)keyPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaKeySession*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetKeySystem(string[] keySystemSa)
        {
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IMFMediaKeySession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
