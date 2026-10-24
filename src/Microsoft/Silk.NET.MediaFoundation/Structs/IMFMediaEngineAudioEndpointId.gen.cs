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
    [Guid("7a3bac98-0e76-49fb-8c20-8a86fd98eaf2")]
    [NativeName("Name", "IMFMediaEngineAudioEndpointId")]
    public unsafe partial struct IMFMediaEngineAudioEndpointId : IComVtbl<IMFMediaEngineAudioEndpointId>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7a3bac98-0e76-49fb-8c20-8a86fd98eaf2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFMediaEngineAudioEndpointId val)
            => Unsafe.As<IMFMediaEngineAudioEndpointId, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFMediaEngineAudioEndpointId
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
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetAudioEndpointId([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszEndpointId)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char*, int>)@this->LpVtbl[3])(@this, pszEndpointId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAudioEndpointId([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszEndpointId)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszEndpointIdPtr = &pszEndpointId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char*, int>)@this->LpVtbl[3])(@this, pszEndpointIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAudioEndpointId([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszEndpointId)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszEndpointIdPtr = (byte*) SilkMarshal.StringToPtr(pszEndpointId, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, byte*, int>)@this->LpVtbl[3])(@this, pszEndpointIdPtr);
            SilkMarshal.Free((nint)pszEndpointIdPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAudioEndpointId(char** ppszEndpointId)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char**, int>)@this->LpVtbl[4])(@this, ppszEndpointId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAudioEndpointId(ref char* ppszEndpointId)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppszEndpointIdPtr = &ppszEndpointId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineAudioEndpointId*, char**, int>)@this->LpVtbl[4])(@this, ppszEndpointIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAudioEndpointId(string[] ppszEndpointIdSa)
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszEndpointId = (char**) SilkMarshal.StringArrayToPtr(ppszEndpointIdSa);
            var ret = @this->GetAudioEndpointId(ppszEndpointId);
            SilkMarshal.CopyPtrToStringArray((nint) ppszEndpointId, ppszEndpointIdSa);
            SilkMarshal.Free((nint) ppszEndpointId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFMediaEngineAudioEndpointId*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
