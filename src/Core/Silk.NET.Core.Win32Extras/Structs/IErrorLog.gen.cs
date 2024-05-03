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
    [Guid("3127ca40-446e-11ce-8135-00aa004bb851")]
    [NativeName("Name", "IErrorLog")]
    public unsafe partial struct IErrorLog : IComVtbl<IErrorLog>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3127ca40-446e-11ce-8135-00aa004bb851");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IErrorLog val)
            => Unsafe.As<IErrorLog, Silk.NET.Core.Native.IUnknown>(ref val);

        public IErrorLog
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
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ExceptionInfo* pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropName, pExcepInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref ExceptionInfo pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropName, pExcepInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ExceptionInfo* pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref ExceptionInfo pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, char*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ExceptionInfo* pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, byte*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfo);
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddError([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref ExceptionInfo pExcepInfo)
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IErrorLog*, byte*, ExceptionInfo*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pExcepInfoPtr);
            }
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IErrorLog*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
