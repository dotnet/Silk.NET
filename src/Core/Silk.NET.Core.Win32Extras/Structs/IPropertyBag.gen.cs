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
    [Guid("55272a00-42cb-11ce-8135-00aa004bb851")]
    [NativeName("Name", "IPropertyBag")]
    public unsafe partial struct IPropertyBag : IComVtbl<IPropertyBag>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("55272a00-42cb-11ce-8135-00aa004bb851");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPropertyBag val)
            => Unsafe.As<IPropertyBag, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPropertyBag
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
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVar, pErrorLog);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVar, pErrorLogPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVarPtr, pErrorLog);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarPtr = &pVar)
            {
                fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropName, pVarPtr, pErrorLogPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLog);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLogPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                fixed (Variant* pVarPtr = &pVar)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLog);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Read([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                fixed (Variant* pVarPtr = &pVar)
                {
                    fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLogPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLog);
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVar, pErrorLogPtr);
            }
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, IErrorLog* pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLog);
            }
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Read([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, ref IErrorLog pErrorLog)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            fixed (Variant* pVarPtr = &pVar)
            {
                fixed (IErrorLog* pErrorLogPtr = &pErrorLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, IErrorLog*, int>)@this->LpVtbl[3])(@this, pszPropNamePtr, pVarPtr, pErrorLogPtr);
                }
            }
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropName, pVar);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropName, pVarPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVar);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszPropNamePtr = &pszPropName)
            {
                fixed (Variant* pVarPtr = &pVar)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, char*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVarPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVar);
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar)
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszPropNamePtr = (byte*) SilkMarshal.StringToPtr(pszPropName, NativeStringEncoding.UTF8);
            fixed (Variant* pVarPtr = &pVar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag*, byte*, Variant*, int>)@this->LpVtbl[4])(@this, pszPropNamePtr, pVarPtr);
            }
            SilkMarshal.Free((nint)pszPropNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(in pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(in pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, Variant* pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(pszPropName, pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszPropName, ref Variant pVar, ComPtr<TI0> pErrorLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(pszPropName, ref pVar, (IErrorLog*) pErrorLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyBag*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
