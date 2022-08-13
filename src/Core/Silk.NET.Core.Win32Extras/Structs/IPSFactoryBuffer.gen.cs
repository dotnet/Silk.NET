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
    [Guid("d5f569d0-593b-101a-b569-08002b2dbf7a")]
    [NativeName("Name", "IPSFactoryBuffer")]
    public unsafe partial struct IPSFactoryBuffer
    {
        public static readonly Guid Guid = new("d5f569d0-593b-101a-b569-08002b2dbf7a");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPSFactoryBuffer val)
            => Unsafe.As<IPSFactoryBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPSFactoryBuffer
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
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riid, ppProxy, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riid, ppProxyPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riid, ppProxyPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxy, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxy, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxyPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(Silk.NET.Core.Native.IUnknown* pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuter, riidPtr, ppProxyPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxy, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxy, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxyPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, Guid* riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riid, ppProxyPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxy, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, IRpcProxyBuffer** ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxy, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, void** ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxyPtr, ppv);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateProxy(ref Silk.NET.Core.Native.IUnknown pUnkOuter, ref Guid riid, ref IRpcProxyBuffer* ppProxy, ref void* ppv)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkOuterPtr = &pUnkOuter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (IRpcProxyBuffer** ppProxyPtr = &ppProxy)
                    {
                        fixed (void** ppvPtr = &ppv)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Silk.NET.Core.Native.IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)LpVtbl[3])(@this, pUnkOuterPtr, riidPtr, ppProxyPtr, ppvPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riid, pUnkServer, ppStub);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(Guid* riid, Silk.NET.Core.Native.IUnknown* pUnkServer, ref IRpcStubBuffer* ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riid, pUnkServer, ppStubPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(Guid* riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, IRpcStubBuffer** ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riid, pUnkServerPtr, ppStub);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(Guid* riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref IRpcStubBuffer* ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
            {
                fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riid, pUnkServerPtr, ppStubPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(ref Guid riid, Silk.NET.Core.Native.IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riidPtr, pUnkServer, ppStub);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(ref Guid riid, Silk.NET.Core.Native.IUnknown* pUnkServer, ref IRpcStubBuffer* ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riidPtr, pUnkServer, ppStubPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, IRpcStubBuffer** ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riidPtr, pUnkServerPtr, ppStub);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStub(ref Guid riid, ref Silk.NET.Core.Native.IUnknown pUnkServer, ref IRpcStubBuffer* ppStub)
        {
            var @this = (IPSFactoryBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnkServerPtr = &pUnkServer)
                {
                    fixed (IRpcStubBuffer** ppStubPtr = &ppStub)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPSFactoryBuffer*, Guid*, Silk.NET.Core.Native.IUnknown*, IRpcStubBuffer**, int>)LpVtbl[4])(@this, riidPtr, pUnkServerPtr, ppStubPtr);
                    }
                }
            }
            return ret;
        }

    }
}
