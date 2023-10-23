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

namespace Silk.NET.WindowsCodecs
{
    [Guid("f7836e16-3be0-470b-86bb-160d0aecd7de")]
    [NativeName("Name", "IWICMetadataWriter")]
    public unsafe partial struct IWICMetadataWriter : IComVtbl<IWICMetadataWriter>, IComVtbl<IWICMetadataReader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f7836e16-3be0-470b-86bb-160d0aecd7de");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICMetadataReader(IWICMetadataWriter val)
            => Unsafe.As<IWICMetadataWriter, IWICMetadataReader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICMetadataWriter val)
            => Unsafe.As<IWICMetadataWriter, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICMetadataWriter
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
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataFormat(ref Guid pguidMetadataFormat)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidMetadataFormatPtr = &pguidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataHandlerInfo(ref IWICMetadataHandlerInfo* ppIHandler)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataHandlerInfo** ppIHandlerPtr = &ppIHandler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandlerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCount(uint* pcCount)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint*, int>)@this->LpVtbl[5])(@this, pcCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCount(ref uint pcCount)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint*, int>)@this->LpVtbl[5])(@this, pcCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex(uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0>(uint nIndex, void* pvarSchema, void* pvarId, ref T0 pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0>(uint nIndex, void* pvarSchema, ref T0 pvarId, void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0, T1>(uint nIndex, void* pvarSchema, ref T0 pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0>(uint nIndex, ref T0 pvarSchema, void* pvarId, void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0, T1>(uint nIndex, ref T0 pvarSchema, void* pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByIndex<T0, T1>(uint nIndex, ref T0 pvarSchema, ref T1 pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValueByIndex<T0, T1, T2>(uint nIndex, ref T0 pvarSchema, ref T1 pvarId, ref T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    fixed (void* pvarValuePtr = &pvarValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, void* pvarValue)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, ref T0 pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValue<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, ref T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    fixed (void* pvarValuePtr = &pvarValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadata);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnumerator(ref IWICEnumMetadataItem* ppIEnumMetadata)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICEnumMetadataItem** ppIEnumMetadataPtr = &ppIEnumMetadata)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarId, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarId, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarIdPtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarIdPtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarId, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarId, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarIdPtr, pvarValue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValue<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    fixed (void* pvarValuePtr = &pvarValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarId, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarId, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0, T1>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0, T1>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByIndex<T0, T1>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValue);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValueByIndex<T0, T1, T2>(uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    fixed (void* pvarValuePtr = &pvarValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchema, pvarId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarId) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchema, pvarIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId) where T0 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchemaPtr, pvarId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveValue<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T1 pvarId) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvarSchemaPtr = &pvarSchema)
            {
                fixed (void* pvarIdPtr = &pvarId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchemaPtr, pvarIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveValueByIndex(uint nIndex)
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, int>)@this->LpVtbl[12])(@this, nIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataHandlerInfo<TI0>(ref ComPtr<TI0> ppIHandler) where TI0 : unmanaged, IComVtbl<IWICMetadataHandlerInfo>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMetadataHandlerInfo((IWICMetadataHandlerInfo**) ppIHandler.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEnumerator<TI0>(ref ComPtr<TI0> ppIEnumMetadata) where TI0 : unmanaged, IComVtbl<IWICEnumMetadataItem>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEnumerator((IWICEnumMetadataItem**) ppIEnumMetadata.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataWriter*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
