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
    [Guid("22f55882-280b-11d0-a8a9-00a0c90c2004")]
    [NativeName("Name", "IPropertyBag2")]
    public unsafe partial struct IPropertyBag2 : IComVtbl<IPropertyBag2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("22f55882-280b-11d0-a8a9-00a0c90c2004");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPropertyBag2 val)
            => Unsafe.As<IPropertyBag2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPropertyBag2
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
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValue, phrError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* phrErrorPtr = &phrError)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValue, phrErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValuePtr, phrError);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValuePtr, phrErrorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValue, phrError);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValue, phrErrorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValuePtr, phrError);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    fixed (int* phrErrorPtr = &phrError)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValuePtr, phrErrorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, Variant* pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValue, phrError);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, Variant* pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValue, phrErrorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValuePtr, phrError);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    fixed (int* phrErrorPtr = &phrError)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValuePtr, phrErrorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValue, phrError);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    fixed (int* phrErrorPtr = &phrError)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValue, phrErrorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, int* phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    fixed (Variant* pvarValuePtr = &pvarValue)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValuePtr, phrError);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Read(uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, ref int phrError)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    fixed (Variant* pvarValuePtr = &pvarValue)
                    {
                        fixed (int* phrErrorPtr = &phrError)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValuePtr, phrErrorPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write(uint cProperties, PropBag2* pPropBag, Variant* pvarValue)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBag, pvarValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write(uint cProperties, PropBag2* pPropBag, ref Variant pvarValue)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBag, pvarValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write(uint cProperties, ref PropBag2 pPropBag, Variant* pvarValue)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBagPtr, pvarValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write(uint cProperties, ref PropBag2 pPropBag, ref Variant pvarValue)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBagPtr, pvarValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CountProperties(uint* pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint*, int>)@this->LpVtbl[5])(@this, pcProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CountProperties(ref uint pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcPropertiesPtr = &pcProperties)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint*, int>)@this->LpVtbl[5])(@this, pcPropertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyInfo(uint iProperty, uint cProperties, PropBag2* pPropBag, uint* pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBag, pcProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyInfo(uint iProperty, uint cProperties, PropBag2* pPropBag, ref uint pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcPropertiesPtr = &pcProperties)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBag, pcPropertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyInfo(uint iProperty, uint cProperties, ref PropBag2 pPropBag, uint* pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBagPtr, pcProperties);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyInfo(uint iProperty, uint cProperties, ref PropBag2 pPropBag, ref uint pcProperties)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropBag2* pPropBagPtr = &pPropBag)
            {
                fixed (uint* pcPropertiesPtr = &pcProperties)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBagPtr, pcPropertiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObject, pErrLog);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObject, pErrLogPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObjectPtr, pErrLog);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObjectPtr, pErrLogPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pstrNamePtr = &pstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLog);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pstrNamePtr = &pstrName)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLogPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pstrNamePtr = &pstrName)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLog);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pstrNamePtr = &pstrName)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
                {
                    fixed (IErrorLog* pErrLogPtr = &pErrLog)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLogPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLog);
            SilkMarshal.Free((nint)pstrNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLogPtr);
            }
            SilkMarshal.Free((nint)pstrNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLog);
            }
            SilkMarshal.Free((nint)pstrNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLogPtr);
                }
            }
            SilkMarshal.Free((nint)pstrNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, ref phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, ref phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, ref phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<TI0>(uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read<TI0>(uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, ref phrError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(in pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(in pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(in pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadObject(pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyBag2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
