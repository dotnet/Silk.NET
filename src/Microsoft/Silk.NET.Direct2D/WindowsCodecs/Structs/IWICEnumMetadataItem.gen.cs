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
    [Guid("dc2bb46d-3f07-481e-8625-220c4aedbb33")]
    [NativeName("Name", "IWICEnumMetadataItem")]
    public unsafe partial struct IWICEnumMetadataItem : IComVtbl<IWICEnumMetadataItem>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dc2bb46d-3f07-481e-8625-220c4aedbb33");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICEnumMetadataItem val)
            => Unsafe.As<IWICEnumMetadataItem, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICEnumMetadataItem
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
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValue, pceltFetchedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValuePtr, pceltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltId, rgeltValuePtr, pceltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValue, pceltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValue, pceltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValuePtr, pceltFetched);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, Silk.NET.Core.Win32Extras.PropVariant* rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                {
                    fixed (uint* pceltFetchedPtr = &pceltFetched)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchema, rgeltIdPtr, rgeltValuePtr, pceltFetchedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValue, pceltFetched);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (uint* pceltFetchedPtr = &pceltFetched)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValue, pceltFetchedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValuePtr, pceltFetched);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, Silk.NET.Core.Win32Extras.PropVariant* rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                {
                    fixed (uint* pceltFetchedPtr = &pceltFetched)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltId, rgeltValuePtr, pceltFetchedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValue, pceltFetched);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, Silk.NET.Core.Win32Extras.PropVariant* rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
                {
                    fixed (uint* pceltFetchedPtr = &pceltFetched)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValue, pceltFetchedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, uint* pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
                {
                    fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValuePtr, pceltFetched);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Next(uint celt, ref Silk.NET.Core.Win32Extras.PropVariant rgeltSchema, ref Silk.NET.Core.Win32Extras.PropVariant rgeltId, ref Silk.NET.Core.Win32Extras.PropVariant rgeltValue, ref uint pceltFetched)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltSchemaPtr = &rgeltSchema)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltIdPtr = &rgeltId)
                {
                    fixed (Silk.NET.Core.Win32Extras.PropVariant* rgeltValuePtr = &rgeltValue)
                    {
                        fixed (uint* pceltFetchedPtr = &pceltFetched)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltSchemaPtr, rgeltIdPtr, rgeltValuePtr, pceltFetchedPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Skip(uint celt)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, uint, int>)@this->LpVtbl[4])(@this, celt);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset()
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(IWICEnumMetadataItem** ppIEnumMetadataItem)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataItem);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref IWICEnumMetadataItem* ppIEnumMetadataItem)
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICEnumMetadataItem** ppIEnumMetadataItemPtr = &ppIEnumMetadataItem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int>)@this->LpVtbl[6])(@this, ppIEnumMetadataItemPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> ppIEnumMetadataItem) where TI0 : unmanaged, IComVtbl<IWICEnumMetadataItem>, IComVtbl<TI0>
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((IWICEnumMetadataItem**) ppIEnumMetadataItem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICEnumMetadataItem*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
