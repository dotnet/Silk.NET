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
    [Guid("0000002f-0000-0000-c000-000000000046")]
    [NativeName("Name", "IRecordInfo")]
    public unsafe partial struct IRecordInfo : IComVtbl<IRecordInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000002f-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IRecordInfo val)
            => Unsafe.As<IRecordInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IRecordInfo
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
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordInit(void* pvNew)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[3])(@this, pvNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RecordInit<T0>(ref T0 pvNew) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvNewPtr = &pvNew)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[3])(@this, pvNewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordClear(void* pvExisting)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[4])(@this, pvExisting);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RecordClear<T0>(ref T0 pvExisting) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvExistingPtr = &pvExisting)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[4])(@this, pvExistingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCopy(void* pvExisting, void* pvNew)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExisting, pvNew);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCopy<T0>(void* pvExisting, ref T0 pvNew) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvNewPtr = &pvNew)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExisting, pvNewPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCopy<T0>(ref T0 pvExisting, void* pvNew) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvExistingPtr = &pvExisting)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExistingPtr, pvNew);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RecordCopy<T0, T1>(ref T0 pvExisting, ref T1 pvNew) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvExistingPtr = &pvExisting)
            {
                fixed (void* pvNewPtr = &pvNew)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void*, int>)@this->LpVtbl[5])(@this, pvExistingPtr, pvNewPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGuid(Guid* pguid)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, int>)@this->LpVtbl[6])(@this, pguid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGuid(ref Guid pguid)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPtr = &pguid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, Guid*, int>)@this->LpVtbl[6])(@this, pguidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** pbstrName)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, char**, int>)@this->LpVtbl[7])(@this, pbstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* pbstrName)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pbstrNamePtr = &pbstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, char**, int>)@this->LpVtbl[7])(@this, pbstrNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* pcbSize)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, int>)@this->LpVtbl[8])(@this, pcbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint pcbSize)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbSizePtr = &pcbSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, int>)@this->LpVtbl[8])(@this, pcbSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfo(ITypeInfo** ppTypeInfo)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, ITypeInfo**, int>)@this->LpVtbl[9])(@this, ppTypeInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfo(ref ITypeInfo* ppTypeInfo)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ITypeInfo** ppTypeInfoPtr = &ppTypeInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, ITypeInfo**, int>)@this->LpVtbl[9])(@this, ppTypeInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldName, pvarField);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldName, pvarFieldPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvData, szFieldNamePtr, pvarFieldPtr);
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldName, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldName, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarField);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (Variant* pvarFieldPtr = &pvarField)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetField<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, int>)@this->LpVtbl[10])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarField, ppvDataCArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarField, ppvDataCArrayPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarFieldPtr, ppvDataCArray);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldName, pvarFieldPtr, ppvDataCArrayPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArray);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArray);
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, void** ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy(void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, ref void* ppvDataCArray)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvData, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                }
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarField, ppvDataCArray);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarField, ppvDataCArrayPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarFieldPtr, ppvDataCArray);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldName, pvarFieldPtr, ppvDataCArrayPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArray);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (Variant* pvarFieldPtr = &pvarField)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (Variant* pvarFieldPtr = &pvarField)
                    {
                        fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, char*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArray);
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarField, ppvDataCArrayPtr);
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, void** ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArray);
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNoCopy<T0>(ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField, ref void* ppvDataCArray) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    fixed (void** ppvDataCArrayPtr = &ppvDataCArray)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, byte*, Variant*, void**, int>)@this->LpVtbl[11])(@this, pvDataPtr, szFieldNamePtr, pvarFieldPtr, ppvDataCArrayPtr);
                    }
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldName, pvarField);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldName, pvarFieldPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldName, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldName, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (Variant* pvarFieldPtr = &pvarField)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PutField<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[12])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldName, pvarField);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldName, pvarFieldPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* szFieldNamePtr = &szFieldName)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy(uint wFlags, void* pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
            fixed (Variant* pvarFieldPtr = &pvarField)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvData, szFieldNamePtr, pvarFieldPtr);
            }
            SilkMarshal.Free((nint)szFieldNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldName, pvarField);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldName, pvarFieldPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
                fixed (char* szFieldNamePtr = &szFieldName)
                {
                    fixed (Variant* pvarFieldPtr = &pvarField)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, char*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, Variant* pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarField);
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PutFieldNoCopy<T0>(uint wFlags, ref T0 pvData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szFieldName, ref Variant pvarField) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDataPtr = &pvData)
            {
            var szFieldNamePtr = (byte*) SilkMarshal.StringToPtr(szFieldName, NativeStringEncoding.UTF8);
                fixed (Variant* pvarFieldPtr = &pvarField)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint, void*, byte*, Variant*, int>)@this->LpVtbl[13])(@this, wFlags, pvDataPtr, szFieldNamePtr, pvarFieldPtr);
                }
            SilkMarshal.Free((nint)szFieldNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNames(uint* pcNames, char** rgBstrNames)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNames, rgBstrNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNames(uint* pcNames, ref char* rgBstrNames)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rgBstrNamesPtr = &rgBstrNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNames, rgBstrNamesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNames(ref uint pcNames, char** rgBstrNames)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcNamesPtr = &pcNames)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNamesPtr, rgBstrNames);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNames(ref uint pcNames, ref char* rgBstrNames)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcNamesPtr = &pcNames)
            {
                fixed (char** rgBstrNamesPtr = &rgBstrNames)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, uint*, char**, int>)@this->LpVtbl[14])(@this, pcNamesPtr, rgBstrNamesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 IsMatchingType(IRecordInfo* pRecordInfo)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, IRecordInfo*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this, pRecordInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMatchingType(ref IRecordInfo pRecordInfo)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            fixed (IRecordInfo* pRecordInfoPtr = &pRecordInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, IRecordInfo*, Silk.NET.Core.Bool32>)@this->LpVtbl[15])(@this, pRecordInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* RecordCreate()
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCreateCopy(void* pvSource, void** ppvDest)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSource, ppvDest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCreateCopy(void* pvSource, ref void* ppvDest)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDestPtr = &ppvDest)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSource, ppvDestPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCreateCopy<T0>(ref T0 pvSource, void** ppvDest) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvSourcePtr = &pvSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSourcePtr, ppvDest);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordCreateCopy<T0>(ref T0 pvSource, ref void* ppvDest) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvSourcePtr = &pvSource)
            {
                fixed (void** ppvDestPtr = &ppvDest)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, void**, int>)@this->LpVtbl[17])(@this, pvSourcePtr, ppvDestPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RecordDestroy(void* pvRecord)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[18])(@this, pvRecord);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RecordDestroy<T0>(ref T0 pvRecord) where T0 : unmanaged
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvRecordPtr = &pvRecord)
            {
                ret = ((delegate* unmanaged[Cdecl]<IRecordInfo*, void*, int>)@this->LpVtbl[18])(@this, pvRecordPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetName(string[] pbstrNameSa)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pbstrName = (char**) SilkMarshal.StringArrayToPtr(pbstrNameSa);
            var ret = @this->GetName(pbstrName);
            SilkMarshal.CopyPtrToStringArray((nint) pbstrName, pbstrNameSa);
            SilkMarshal.Free((nint) pbstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypeInfo<TI0>(ref ComPtr<TI0> ppTypeInfo) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypeInfo((ITypeInfo**) ppTypeInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFieldNames(uint* pcNames, string[] rgBstrNamesSa)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
            var ret = @this->GetFieldNames(pcNames, rgBstrNames);
            SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
            SilkMarshal.Free((nint) rgBstrNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFieldNames(ref uint pcNames, string[] rgBstrNamesSa)
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rgBstrNames = (char**) SilkMarshal.StringArrayToPtr(rgBstrNamesSa);
            var ret = @this->GetFieldNames(ref pcNames, rgBstrNames);
            SilkMarshal.CopyPtrToStringArray((nint) rgBstrNames, rgBstrNamesSa);
            SilkMarshal.Free((nint) rgBstrNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsMatchingType<TI0>(ComPtr<TI0> pRecordInfo) where TI0 : unmanaged, IComVtbl<IRecordInfo>, IComVtbl<TI0>
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsMatchingType((IRecordInfo*) pRecordInfo.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IRecordInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
