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
    [Guid("0002040e-0000-0000-c000-000000000046")]
    [NativeName("Name", "ICreateTypeInfo2")]
    public unsafe partial struct ICreateTypeInfo2 : IComVtbl<ICreateTypeInfo2>, IComVtbl<ICreateTypeInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0002040e-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ICreateTypeInfo(ICreateTypeInfo2 val)
            => Unsafe.As<ICreateTypeInfo2, ICreateTypeInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ICreateTypeInfo2 val)
            => Unsafe.As<ICreateTypeInfo2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ICreateTypeInfo2
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
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGuid(Guid* guid)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, int>)@this->LpVtbl[3])(@this, guid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGuid(ref Guid guid)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, int>)@this->LpVtbl[3])(@this, guidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeFlags(uint uTypeFlags)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[4])(@this, uTypeFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDocString(char* pStrDoc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[5])(@this, pStrDoc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDocString(ref char pStrDoc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pStrDocPtr = &pStrDoc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[5])(@this, pStrDocPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDocString([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrDoc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pStrDocPtr = (byte*) SilkMarshal.StringToPtr(pStrDoc, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[5])(@this, pStrDocPtr);
            SilkMarshal.Free((nint)pStrDocPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpContext(uint dwHelpContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[6])(@this, dwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVersion(ushort wMajorVerNum, ushort wMinorVerNum)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ushort, ushort, int>)@this->LpVtbl[7])(@this, wMajorVerNum, wMinorVerNum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRefTypeInfo(ITypeInfo* pTInfo, uint* phRefType)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfo, phRefType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRefTypeInfo(ITypeInfo* pTInfo, ref uint phRefType)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* phRefTypePtr = &phRefType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfo, phRefTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRefTypeInfo(ref ITypeInfo pTInfo, uint* phRefType)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTInfoPtr = &pTInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfoPtr, phRefType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRefTypeInfo(ref ITypeInfo pTInfo, ref uint phRefType)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo* pTInfoPtr = &pTInfo)
            {
                fixed (uint* phRefTypePtr = &phRefType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ITypeInfo*, uint*, int>)@this->LpVtbl[8])(@this, pTInfoPtr, phRefTypePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddFuncDesc(uint index, FuncDesc* pFuncDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, FuncDesc*, int>)@this->LpVtbl[9])(@this, index, pFuncDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddFuncDesc(uint index, ref FuncDesc pFuncDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FuncDesc* pFuncDescPtr = &pFuncDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, FuncDesc*, int>)@this->LpVtbl[9])(@this, index, pFuncDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddImplType(uint index, uint hRefType)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[10])(@this, index, hRefType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetImplTypeFlags(uint index, int implTypeFlags)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int, int>)@this->LpVtbl[11])(@this, index, implTypeFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAlignment(ushort cbAlignment)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, ushort, int>)@this->LpVtbl[12])(@this, cbAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSchema(char* pStrSchema)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[13])(@this, pStrSchema);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSchema(ref char pStrSchema)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pStrSchemaPtr = &pStrSchema)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[13])(@this, pStrSchemaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSchema([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStrSchema)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pStrSchemaPtr = (byte*) SilkMarshal.StringToPtr(pStrSchema, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[13])(@this, pStrSchemaPtr);
            SilkMarshal.Free((nint)pStrSchemaPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddVarDesc(uint index, VarDesc* pVarDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, VarDesc*, int>)@this->LpVtbl[14])(@this, index, pVarDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddVarDesc(uint index, ref VarDesc pVarDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VarDesc* pVarDescPtr = &pVarDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, VarDesc*, int>)@this->LpVtbl[14])(@this, index, pVarDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncAndParamNames(uint index, char** rgszNames, uint cNames)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char**, uint, int>)@this->LpVtbl[15])(@this, index, rgszNames, cNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncAndParamNames(uint index, ref char* rgszNames, uint cNames)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgszNamesPtr = &rgszNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char**, uint, int>)@this->LpVtbl[15])(@this, index, rgszNamesPtr, cNames);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVarName(uint index, char* szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[16])(@this, index, szName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarName(uint index, ref char szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[16])(@this, index, szNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarName(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[16])(@this, index, szNamePtr);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypeDescAlias(TypeDesc* pTDescAlias)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, TypeDesc*, int>)@this->LpVtbl[17])(@this, pTDescAlias);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeDescAlias(ref TypeDesc pTDescAlias)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TypeDesc* pTDescAliasPtr = &pTDescAlias)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, TypeDesc*, int>)@this->LpVtbl[17])(@this, pTDescAliasPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DefineFuncAsDllEntry(uint index, char* szDllName, char* szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DefineFuncAsDllEntry(uint index, char* szDllName, ref char szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szProcNamePtr = &szProcName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DefineFuncAsDllEntry(uint index, char* szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllName, szProcNamePtr);
            SilkMarshal.Free((nint)szProcNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DefineFuncAsDllEntry(uint index, ref char szDllName, char* szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDllNamePtr = &szDllName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DefineFuncAsDllEntry(uint index, ref char szDllName, ref char szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDllNamePtr = &szDllName)
            {
                fixed (char* szProcNamePtr = &szProcName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DefineFuncAsDllEntry(uint index, ref char szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDllNamePtr = &szDllName)
            {
            var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
            SilkMarshal.Free((nint)szProcNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DefineFuncAsDllEntry(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, char* szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcName);
            SilkMarshal.Free((nint)szDllNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DefineFuncAsDllEntry(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, ref char szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
            fixed (char* szProcNamePtr = &szProcName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, char*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
            }
            SilkMarshal.Free((nint)szDllNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DefineFuncAsDllEntry(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDllName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szProcName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDllNamePtr = (byte*) SilkMarshal.StringToPtr(szDllName, NativeStringEncoding.UTF8);
            var szProcNamePtr = (byte*) SilkMarshal.StringToPtr(szProcName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, byte*, int>)@this->LpVtbl[18])(@this, index, szDllNamePtr, szProcNamePtr);
            SilkMarshal.Free((nint)szProcNamePtr);
            SilkMarshal.Free((nint)szDllNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncDocString(uint index, char* szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[19])(@this, index, szDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncDocString(uint index, ref char szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDocStringPtr = &szDocString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[19])(@this, index, szDocStringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncDocString(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDocStringPtr = (byte*) SilkMarshal.StringToPtr(szDocString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[19])(@this, index, szDocStringPtr);
            SilkMarshal.Free((nint)szDocStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVarDocString(uint index, char* szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[20])(@this, index, szDocString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarDocString(uint index, ref char szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szDocStringPtr = &szDocString)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[20])(@this, index, szDocStringPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarDocString(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szDocString)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szDocStringPtr = (byte*) SilkMarshal.StringToPtr(szDocString, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[20])(@this, index, szDocStringPtr);
            SilkMarshal.Free((nint)szDocStringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncHelpContext(uint index, uint dwHelpContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[21])(@this, index, dwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarHelpContext(uint index, uint dwHelpContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[22])(@this, index, dwHelpContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMops(uint index, char* bstrMops)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[23])(@this, index, bstrMops);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMops(uint index, ref char bstrMops)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* bstrMopsPtr = &bstrMops)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, char*, int>)@this->LpVtbl[23])(@this, index, bstrMopsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMops(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string bstrMops)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bstrMopsPtr = (byte*) SilkMarshal.StringToPtr(bstrMops, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, byte*, int>)@this->LpVtbl[23])(@this, index, bstrMopsPtr);
            SilkMarshal.Free((nint)bstrMopsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypeIdldesc(IdlDesc* pIdlDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, IdlDesc*, int>)@this->LpVtbl[24])(@this, pIdlDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypeIdldesc(ref IdlDesc pIdlDesc)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IdlDesc* pIdlDescPtr = &pIdlDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, IdlDesc*, int>)@this->LpVtbl[24])(@this, pIdlDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LayOut()
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteFuncDesc(uint index)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[26])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteFuncDescByMemId(int memid, InvokeKind invKind)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int, InvokeKind, int>)@this->LpVtbl[27])(@this, memid, invKind);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteVarDesc(uint index)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[28])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteVarDescByMemId(int memid)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int, int>)@this->LpVtbl[29])(@this, memid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteImplType(uint index)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[30])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCustData(Guid* guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCustData(Guid* guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCustData(ref Guid guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCustData(ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, Guid*, Variant*, int>)@this->LpVtbl[31])(@this, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFuncCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[32])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetParamCustData(uint indexFunc, uint indexParam, Guid* guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetParamCustData(uint indexFunc, uint indexParam, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetParamCustData(uint indexFunc, uint indexParam, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParamCustData(uint indexFunc, uint indexParam, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, Guid*, Variant*, int>)@this->LpVtbl[33])(@this, indexFunc, indexParam, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVarCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVarCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVarCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[34])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetImplTypeCustData(uint index, Guid* guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guid, pVarVal);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetImplTypeCustData(uint index, Guid* guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pVarValPtr = &pVarVal)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guid, pVarValPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetImplTypeCustData(uint index, ref Guid guid, Variant* pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guidPtr, pVarVal);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetImplTypeCustData(uint index, ref Guid guid, ref Variant pVarVal)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Variant* pVarValPtr = &pVarVal)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, Guid*, Variant*, int>)@this->LpVtbl[35])(@this, index, guidPtr, pVarValPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetHelpStringContext(uint dwHelpStringContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, int>)@this->LpVtbl[36])(@this, dwHelpStringContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncHelpStringContext(uint index, uint dwHelpStringContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[37])(@this, index, dwHelpStringContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVarHelpStringContext(uint index, uint dwHelpStringContext)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, uint, uint, int>)@this->LpVtbl[38])(@this, index, dwHelpStringContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Invalidate()
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, int>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[40])(@this, szName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szNamePtr = &szName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, char*, int>)@this->LpVtbl[40])(@this, szNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szNamePtr = (byte*) SilkMarshal.StringToPtr(szName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ICreateTypeInfo2*, byte*, int>)@this->LpVtbl[40])(@this, szNamePtr);
            SilkMarshal.Free((nint)szNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddRefTypeInfo<TI0>(ComPtr<TI0> pTInfo, uint* phRefType) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddRefTypeInfo((ITypeInfo*) pTInfo.Handle, phRefType);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddRefTypeInfo<TI0>(ComPtr<TI0> pTInfo, ref uint phRefType) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddRefTypeInfo((ITypeInfo*) pTInfo.Handle, ref phRefType);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFuncAndParamNames(uint index, string[] rgszNamesSa, uint cNames)
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgszNames = (char**) SilkMarshal.StringArrayToPtr(rgszNamesSa);
            var ret = @this->SetFuncAndParamNames(index, rgszNames, cNames);
            SilkMarshal.CopyPtrToStringArray((nint) rgszNames, rgszNamesSa);
            SilkMarshal.Free((nint) rgszNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ICreateTypeInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
