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
    [Guid("0000000f-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMoniker")]
    public unsafe partial struct IMoniker : IComVtbl<IMoniker>, IComVtbl<IPersistStream>, IComVtbl<IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000000f-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IPersistStream(IMoniker val)
            => Unsafe.As<IMoniker, IPersistStream>(ref val);

        public static implicit operator IPersist(IMoniker val)
            => Unsafe.As<IMoniker, IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMoniker val)
            => Unsafe.As<IMoniker, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMoniker
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
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(Silk.NET.Core.Win32Extras.IStream* pStm)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref Silk.NET.Core.Win32Extras.IStream pStm)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStmPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save(Silk.NET.Core.Win32Extras.IStream* pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStm, fClearDirty);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save(ref Silk.NET.Core.Win32Extras.IStream pStm, Silk.NET.Core.Bool32 fClearDirty)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStmPtr, fClearDirty);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeMax(ulong* pcbSize)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSizeMax(ref ulong pcbSize)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pcbSizePtr = &pcbSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResult, ppvResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvResultPtr = &ppvResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResult, ppvResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResultPtr = &riidResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResultPtr, ppvResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidResultPtr = &riidResult)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResultPtr, ppvResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResult, ppvResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResult, ppvResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResultPtr, ppvResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    fixed (void** ppvResultPtr = &ppvResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResultPtr, ppvResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResult, ppvResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResult, ppvResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResultPtr, ppvResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    fixed (void** ppvResultPtr = &ppvResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResultPtr, ppvResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResult, ppvResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (void** ppvResultPtr = &ppvResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResult, ppvResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (Guid* riidResultPtr = &riidResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResultPtr, ppvResult);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (Guid* riidResultPtr = &riidResult)
                    {
                        fixed (void** ppvResultPtr = &ppvResult)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResultPtr, ppvResultPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riid, ppvObj);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riid, ppvObjPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riidPtr, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riidPtr, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riid, ppvObj);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riid, ppvObjPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riidPtr, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riidPtr, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riid, ppvObj);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riid, ppvObjPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riidPtr, ppvObj);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvObjPtr = &ppvObj)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riidPtr, ppvObjPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(IBindCtx* pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(IBindCtx* pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, ref IMoniker* ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeft, ppmkReducedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(IBindCtx* pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, IMoniker** ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeftPtr, ppmkReduced);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(IBindCtx* pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
            {
                fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeftPtr, ppmkReducedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(ref IBindCtx pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeft, ppmkReduced);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(ref IBindCtx pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, ref IMoniker* ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeft, ppmkReducedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, IMoniker** ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeftPtr, ppmkReduced);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce(ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
                {
                    fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeftPtr, ppmkReducedPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComposeWith(IMoniker* pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, IMoniker** ppmkComposite)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRight, fOnlyIfNotGeneric, ppmkComposite);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComposeWith(IMoniker* pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkCompositePtr = &ppmkComposite)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRight, fOnlyIfNotGeneric, ppmkCompositePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComposeWith(ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, IMoniker** ppmkComposite)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkRightPtr = &pmkRight)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRightPtr, fOnlyIfNotGeneric, ppmkComposite);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComposeWith(ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkRightPtr = &pmkRight)
            {
                fixed (IMoniker** ppmkCompositePtr = &ppmkComposite)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRightPtr, fOnlyIfNotGeneric, ppmkCompositePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(Silk.NET.Core.Bool32 fForward, IEnumMoniker** ppenumMoniker)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Bool32, IEnumMoniker**, int>)@this->LpVtbl[12])(@this, fForward, ppenumMoniker);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(Silk.NET.Core.Bool32 fForward, ref IEnumMoniker* ppenumMoniker)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumMoniker** ppenumMonikerPtr = &ppenumMoniker)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Bool32, IEnumMoniker**, int>)@this->LpVtbl[12])(@this, fForward, ppenumMonikerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsEqual(IMoniker* pmkOtherMoniker)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, int>)@this->LpVtbl[13])(@this, pmkOtherMoniker);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual(ref IMoniker pmkOtherMoniker)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkOtherMonikerPtr = &pmkOtherMoniker)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, int>)@this->LpVtbl[13])(@this, pmkOtherMonikerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Hash(uint* pdwHash)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[14])(@this, pdwHash);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Hash(ref uint pdwHash)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwHashPtr = &pdwHash)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[14])(@this, pdwHashPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(IBindCtx* pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeft, pmkNewlyRunning);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(IBindCtx* pbc, IMoniker* pmkToLeft, ref IMoniker pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeft, pmkNewlyRunningPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(IBindCtx* pbc, ref IMoniker pmkToLeft, IMoniker* pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeftPtr, pmkNewlyRunning);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(IBindCtx* pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeftPtr, pmkNewlyRunningPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(ref IBindCtx pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeft, pmkNewlyRunning);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(ref IBindCtx pbc, IMoniker* pmkToLeft, ref IMoniker pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeft, pmkNewlyRunningPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsRunning(ref IBindCtx pbc, ref IMoniker pmkToLeft, IMoniker* pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeftPtr, pmkNewlyRunning);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeftPtr, pmkNewlyRunningPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IBindCtx* pbc, IMoniker* pmkToLeft, Filetime* pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeft, pFileTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IBindCtx* pbc, IMoniker* pmkToLeft, ref Filetime pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pFileTimePtr = &pFileTime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeft, pFileTimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IBindCtx* pbc, ref IMoniker pmkToLeft, Filetime* pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeftPtr, pFileTime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(IBindCtx* pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Filetime* pFileTimePtr = &pFileTime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeftPtr, pFileTimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(ref IBindCtx pbc, IMoniker* pmkToLeft, Filetime* pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeft, pFileTime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(ref IBindCtx pbc, IMoniker* pmkToLeft, ref Filetime pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Filetime* pFileTimePtr = &pFileTime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeft, pFileTimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange(ref IBindCtx pbc, ref IMoniker pmkToLeft, Filetime* pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeftPtr, pFileTime);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (Filetime* pFileTimePtr = &pFileTime)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeftPtr, pFileTimePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Inverse(IMoniker** ppmk)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker**, int>)@this->LpVtbl[17])(@this, ppmk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Inverse(ref IMoniker* ppmk)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkPtr = &ppmk)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker**, int>)@this->LpVtbl[17])(@this, ppmkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CommonPrefixWith(IMoniker* pmkOther, IMoniker** ppmkPrefix)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOther, ppmkPrefix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CommonPrefixWith(IMoniker* pmkOther, ref IMoniker* ppmkPrefix)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkPrefixPtr = &ppmkPrefix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOther, ppmkPrefixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CommonPrefixWith(ref IMoniker pmkOther, IMoniker** ppmkPrefix)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkOtherPtr = &pmkOther)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOtherPtr, ppmkPrefix);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CommonPrefixWith(ref IMoniker pmkOther, ref IMoniker* ppmkPrefix)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkOtherPtr = &pmkOther)
            {
                fixed (IMoniker** ppmkPrefixPtr = &ppmkPrefix)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOtherPtr, ppmkPrefixPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RelativePathTo(IMoniker* pmkOther, IMoniker** ppmkRelPath)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOther, ppmkRelPath);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RelativePathTo(IMoniker* pmkOther, ref IMoniker* ppmkRelPath)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkRelPathPtr = &ppmkRelPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOther, ppmkRelPathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RelativePathTo(ref IMoniker pmkOther, IMoniker** ppmkRelPath)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkOtherPtr = &pmkOther)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOtherPtr, ppmkRelPath);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RelativePathTo(ref IMoniker pmkOther, ref IMoniker* ppmkRelPath)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkOtherPtr = &pmkOther)
            {
                fixed (IMoniker** ppmkRelPathPtr = &ppmkRelPath)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOtherPtr, ppmkRelPathPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, char** ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeft, ppszDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, ref char* ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeft, ppszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, char** ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeftPtr, ppszDisplayName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeftPtr, ppszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, char** ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeft, ppszDisplayName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, ref char* ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeft, ppszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, char** ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeftPtr, ppszDisplayName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeftPtr, ppszDisplayNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
            }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
            }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                }
            }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEaten, ppmkOutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOut);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOut);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (char* pszDisplayNamePtr = &pszDisplayName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (char* pszDisplayNamePtr = &pszDisplayName)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (char* pszDisplayNamePtr = &pszDisplayName)
                    {
                        fixed (uint* pchEatenPtr = &pchEaten)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
                    fixed (char* pszDisplayNamePtr = &pszDisplayName)
                    {
                        fixed (uint* pchEatenPtr = &pchEaten)
                        {
                            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
            SilkMarshal.Free((nint)pszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                    }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                    }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
                {
            var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                        }
                    }
            SilkMarshal.Free((nint)pszDisplayNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsSystemMoniker(uint* pdwMksys)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[22])(@this, pdwMksys);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsSystemMoniker(ref uint pdwMksys)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pdwMksysPtr = &pdwMksys)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[22])(@this, pdwMksysPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Save<TI0>(ComPtr<TI0> pStm, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Save((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, fClearDirty);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToObject<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, out ComPtr<TI2> ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResult = default;
            return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppvResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riidResult, ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToObject<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, out ComPtr<TI1> ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResult = default;
            return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riidResult, ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToObject<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, out ComPtr<TI1> ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResult = default;
            return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riidResult, ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToObject<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riidResult, ref ppvResult);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToObject<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, out ComPtr<TI0> ppvResult) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvResult = default;
            return @this->BindToObject(ref pbc, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToStorage<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, out ComPtr<TI2> ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riid, ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToStorage<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riid, ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToStorage<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riid, ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindToStorage<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riid, ref ppvObj);
        }

        /// <summary>To be documented.</summary>
        public readonly int BindToStorage<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObj = default;
            return @this->BindToStorage(ref pbc, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Reduce<TI0, TI1, TI2>(ComPtr<TI0> pbc, uint dwReduceHowFar, ref ComPtr<TI1> ppmkToLeft, ref ComPtr<TI2> ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), (IMoniker**) ppmkReduced.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce<TI0, TI1>(ComPtr<TI0> pbc, uint dwReduceHowFar, ref ComPtr<TI1> ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), ref ppmkReduced);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce<TI0, TI1>(ComPtr<TI0> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref ComPtr<TI1> ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, ref ppmkToLeft, (IMoniker**) ppmkReduced.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce<TI0>(ComPtr<TI0> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, ref ppmkToLeft, ref ppmkReduced);
        }

        /// <summary>To be documented.</summary>
        public readonly int Reduce<TI0, TI1>(ref IBindCtx pbc, uint dwReduceHowFar, ref ComPtr<TI0> ppmkToLeft, ref ComPtr<TI1> ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce(ref pbc, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), (IMoniker**) ppmkReduced.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce<TI0>(ref IBindCtx pbc, uint dwReduceHowFar, ref ComPtr<TI0> ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce(ref pbc, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), ref ppmkReduced);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reduce<TI0>(ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref ComPtr<TI0> ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Reduce(ref pbc, dwReduceHowFar, ref ppmkToLeft, (IMoniker**) ppmkReduced.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ComposeWith<TI0, TI1>(ComPtr<TI0> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref ComPtr<TI1> ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ComposeWith((IMoniker*) pmkRight.Handle, fOnlyIfNotGeneric, (IMoniker**) ppmkComposite.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComposeWith<TI0>(ComPtr<TI0> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ComposeWith((IMoniker*) pmkRight.Handle, fOnlyIfNotGeneric, ref ppmkComposite);
        }

        /// <summary>To be documented.</summary>
        public readonly int ComposeWith<TI0>(ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref ComPtr<TI0> ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ComposeWith(ref pmkRight, fOnlyIfNotGeneric, (IMoniker**) ppmkComposite.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Enum<TI0>(Silk.NET.Core.Bool32 fForward, ref ComPtr<TI0> ppenumMoniker) where TI0 : unmanaged, IComVtbl<IEnumMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Enum(fForward, (IEnumMoniker**) ppenumMoniker.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int IsEqual<TI0>(ComPtr<TI0> pmkOtherMoniker) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsEqual((IMoniker*) pmkOtherMoniker.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ComPtr<TI2> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, (IMoniker*) pmkNewlyRunning.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pmkNewlyRunning);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ComPtr<TI1> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning((IBindCtx*) pbc.Handle, ref pmkToLeft, (IMoniker*) pmkNewlyRunning.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pmkNewlyRunning);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ComPtr<TI1> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning(ref pbc, (IMoniker*) pmkToLeft.Handle, (IMoniker*) pmkNewlyRunning.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pmkNewlyRunning);
        }

        /// <summary>To be documented.</summary>
        public readonly int IsRunning<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, ComPtr<TI0> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->IsRunning(ref pbc, ref pmkToLeft, (IMoniker*) pmkNewlyRunning.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, ref pmkToLeft, pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTimeOfLastChange<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange(ref pbc, (IMoniker*) pmkToLeft.Handle, pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTimeOfLastChange<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTimeOfLastChange(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pFileTime);
        }

        /// <summary>To be documented.</summary>
        public readonly int Inverse<TI0>(ref ComPtr<TI0> ppmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Inverse((IMoniker**) ppmk.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CommonPrefixWith<TI0, TI1>(ComPtr<TI0> pmkOther, ref ComPtr<TI1> ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CommonPrefixWith((IMoniker*) pmkOther.Handle, (IMoniker**) ppmkPrefix.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CommonPrefixWith<TI0>(ComPtr<TI0> pmkOther, ref IMoniker* ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CommonPrefixWith((IMoniker*) pmkOther.Handle, ref ppmkPrefix);
        }

        /// <summary>To be documented.</summary>
        public readonly int CommonPrefixWith<TI0>(ref IMoniker pmkOther, ref ComPtr<TI0> ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CommonPrefixWith(ref pmkOther, (IMoniker**) ppmkPrefix.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RelativePathTo<TI0, TI1>(ComPtr<TI0> pmkOther, ref ComPtr<TI1> ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RelativePathTo((IMoniker*) pmkOther.Handle, (IMoniker**) ppmkRelPath.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RelativePathTo<TI0>(ComPtr<TI0> pmkOther, ref IMoniker* ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RelativePathTo((IMoniker*) pmkOther.Handle, ref ppmkRelPath);
        }

        /// <summary>To be documented.</summary>
        public readonly int RelativePathTo<TI0>(ref IMoniker pmkOther, ref ComPtr<TI0> ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RelativePathTo(ref pmkOther, (IMoniker**) ppmkRelPath.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, IMoniker* pmkToLeft, string[] ppszDisplayNameSa)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
            var ret = @this->GetDisplayName(pbc, pmkToLeft, ppszDisplayName);
            SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
            SilkMarshal.Free((nint) ppszDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(IBindCtx* pbc, ref IMoniker pmkToLeft, string[] ppszDisplayNameSa)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
            var ret = @this->GetDisplayName(pbc, ref pmkToLeft, ppszDisplayName);
            SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
            SilkMarshal.Free((nint) ppszDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref IBindCtx pbc, IMoniker* pmkToLeft, string[] ppszDisplayNameSa)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
            var ret = @this->GetDisplayName(ref pbc, pmkToLeft, ppszDisplayName);
            SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
            SilkMarshal.Free((nint) ppszDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref ppszDisplayName);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayName(ref IBindCtx pbc, ref IMoniker pmkToLeft, string[] ppszDisplayNameSa)
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
            var ret = @this->GetDisplayName(ref pbc, ref pmkToLeft, ppszDisplayName);
            SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
            SilkMarshal.Free((nint) ppszDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ParseDisplayName<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI2> BindToObject<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToObject(pbc, pmkToLeft, out ComPtr<TI2> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> BindToObject<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToObject(pbc, ref pmkToLeft, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> BindToObject<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToObject(ref pbc, pmkToLeft, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> BindToObject<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToObject(ref pbc, ref pmkToLeft, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI2> BindToStorage<TI0, TI1, TI2>(ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToStorage(pbc, pmkToLeft, out ComPtr<TI2> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> BindToStorage<TI0, TI1>(ComPtr<TI0> pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToStorage(pbc, ref pmkToLeft, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> BindToStorage<TI0, TI1>(ref IBindCtx pbc, ComPtr<TI0> pmkToLeft) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToStorage(ref pbc, pmkToLeft, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> BindToStorage<TI0>(ref IBindCtx pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMoniker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->BindToStorage(ref pbc, ref pmkToLeft, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
