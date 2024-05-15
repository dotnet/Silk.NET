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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("22f03340-547d-101b-8e65-08002b2bd119")]
    [NativeName("Name", "ICreateErrorInfo")]
    public unsafe partial struct ICreateErrorInfo : IComVtbl<ICreateErrorInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("22f03340-547d-101b-8e65-08002b2bd119");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ICreateErrorInfo val)
            => Unsafe.As<ICreateErrorInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public ICreateErrorInfo
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
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGUID(Guid* rguid)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, rguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGUID(ref Guid rguid)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidPtr = &rguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, Guid*, int>)@this->LpVtbl[3])(@this, rguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSource(char* szSource)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[4])(@this, szSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource(ref char szSource)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szSourcePtr = &szSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[4])(@this, szSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSource([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szSource)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szSourcePtr = (byte*) SilkMarshal.StringToPtr(szSource, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, byte*, int>)@this->LpVtbl[4])(@this, szSourcePtr);
            SilkMarshal.Free((nint)szSourcePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDescription(char* szDescription)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[5])(@this, szDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDescription(ref char szDescription)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDescriptionPtr = &szDescription)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[5])(@this, szDescriptionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDescription([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDescription)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDescriptionPtr = (byte*) SilkMarshal.StringToPtr(szDescription, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, byte*, int>)@this->LpVtbl[5])(@this, szDescriptionPtr);
            SilkMarshal.Free((nint)szDescriptionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetHelpFile(char* szHelpFile)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[6])(@this, szHelpFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpFile(ref char szHelpFile)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szHelpFilePtr = &szHelpFile)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, char*, int>)@this->LpVtbl[6])(@this, szHelpFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szHelpFile)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szHelpFilePtr = (byte*) SilkMarshal.StringToPtr(szHelpFile, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, byte*, int>)@this->LpVtbl[6])(@this, szHelpFilePtr);
            SilkMarshal.Free((nint)szHelpFilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpContext(uint dwHelpContext)
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateErrorInfo*, uint, int>)@this->LpVtbl[7])(@this, dwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateErrorInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
