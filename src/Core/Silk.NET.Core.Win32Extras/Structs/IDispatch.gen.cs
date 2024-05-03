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
    [Guid("00020400-0000-0000-c000-000000000046")]
    [NativeName("Name", "IDispatch")]
    public unsafe partial struct IDispatch : IComVtbl<IDispatch>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00020400-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDispatch val)
            => Unsafe.As<IDispatch, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDispatch
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
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfoCount(uint* pctinfo)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint*, int>)@this->LpVtbl[3])(@this, pctinfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeInfoCount(ref uint pctinfo)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pctinfoPtr = &pctinfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint*, int>)@this->LpVtbl[3])(@this, pctinfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfo(uint iTInfo, uint lcid, ITypeInfo** ppTInfo)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfo(uint iTInfo, uint lcid, ref ITypeInfo* ppTInfo)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTInfoPtr = &ppTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, uint, uint, ITypeInfo**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, char** rgszNames, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* rgDispIdPtr = &rgDispId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, ref char* rgszNames, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNamesPtr, cNames, lcid, rgDispId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, ref char* rgszNames, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                fixed (int* rgDispIdPtr = &rgDispId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNamesPtr, cNames, lcid, rgDispIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref Guid riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNames, cNames, lcid, rgDispId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref Guid riid, char** rgszNames, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (int* rgDispIdPtr = &rgDispId)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNames, cNames, lcid, rgDispIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref Guid riid, ref char* rgszNames, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (char** rgszNamesPtr = &rgszNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNamesPtr, cNames, lcid, rgDispId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref Guid riid, ref char* rgszNames, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (char** rgszNamesPtr = &rgszNames)
                {
                    fixed (int* rgDispIdPtr = &rgDispId)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riidPtr, rgszNamesPtr, cNames, lcid, rgDispIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puArgErrPtr = &puArgErr)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarResultPtr = &pVarResult)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DispatchParams* pDispParamsPtr = &pDispParams)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* puArgErrPtr = &puArgErr)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErrPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResult, pExcepInfoPtr, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Variant* pVarResultPtr = &pVarResult)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParams, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (uint* puArgErrPtr = &puArgErr)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfo, puArgErrPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, Variant* pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResult, pExcepInfoPtr, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ExceptionInfo* pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (uint* puArgErrPtr = &puArgErr)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfo, puArgErrPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, uint* puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Invoke(int dispIdMember, ref Guid riid, uint lcid, ushort wFlags, ref DispatchParams pDispParams, ref Variant pVarResult, ref ExceptionInfo pExcepInfo, ref uint puArgErr)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (DispatchParams* pDispParamsPtr = &pDispParams)
                {
                    fixed (Variant* pVarResultPtr = &pVarResult)
                    {
                        fixed (ExceptionInfo* pExcepInfoPtr = &pExcepInfo)
                        {
                            fixed (uint* puArgErrPtr = &puArgErr)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDispatch*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riidPtr, lcid, wFlags, pDispParamsPtr, pVarResultPtr, pExcepInfoPtr, puArgErrPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeInfo<TI0>(uint iTInfo, uint lcid, ref ComPtr<TI0> ppTInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypeInfo(iTInfo, lcid, (ITypeInfo**) ppTInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, string[] rgszNamesSa, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(riid, rgszNames, cNames, lcid, rgDispId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, string[] rgszNamesSa, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(riid, rgszNames, cNames, lcid, ref rgDispId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(ref Guid riid, string[] rgszNamesSa, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(ref riid, rgszNames, cNames, lcid, rgDispId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetIDsOfNames(ref Guid riid, string[] rgszNamesSa, uint cNames, uint lcid, ref int rgDispId)
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->GetIDsOfNames(ref riid, rgszNames, cNames, lcid, ref rgDispId);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDispatch*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
