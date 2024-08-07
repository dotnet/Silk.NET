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
    [Guid("0000013d-0000-0000-c000-000000000046")]
    [NativeName("Name", "IClientSecurity")]
    public unsafe partial struct IClientSecurity : IComVtbl<IClientSecurity>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000013d-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IClientSecurity val)
            => Unsafe.As<IClientSecurity, Silk.NET.Core.Native.IUnknown>(ref val);

        public IClientSecurity
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
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCapabilitesPtr = &pCapabilites)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pAuthInfoPtr = &pAuthInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pAuthInfoPtr = &pAuthInfo)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxy, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pCapabilitesPtr = &pCapabilites)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (void** pAuthInfoPtr = &pAuthInfo)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (void** pAuthInfoPtr = &pAuthInfo)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pCapabilitesPtr = &pCapabilites)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilitesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (void** pAuthInfoPtr = &pAuthInfo)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pImpLevelPtr = &pImpLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilites);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (uint* pCapabilitesPtr = &pCapabilites)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfo, pCapabilitesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (void** pAuthInfoPtr = &pAuthInfo)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pAuthInfoPtr, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (uint* pImpLevelPtr = &pImpLevel)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilites);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (uint* pImpLevelPtr = &pImpLevel)
                                {
                                    fixed (uint* pCapabilitesPtr = &pCapabilites)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfo, pCapabilitesPtr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (uint* pImpLevelPtr = &pImpLevel)
                                {
                                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilites);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
                {
                    fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                    {
                        fixed (char** pServerPrincNamePtr = &pServerPrincName)
                        {
                            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                            {
                                fixed (uint* pImpLevelPtr = &pImpLevel)
                                {
                                    fixed (void** pAuthInfoPtr = &pAuthInfo)
                                    {
                                        fixed (uint* pCapabilitesPtr = &pCapabilites)
                                        {
                                            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pProxyPtr, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pAuthInfoPtr, pCapabilitesPtr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<T0>(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pAuthInfoPtr = &pAuthInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pServerPrincNamePtr = &pServerPrincName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<T0>(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (void* pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pServerPrincNamePtr = (byte*) SilkMarshal.StringToPtr(pServerPrincName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, byte*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            SilkMarshal.Free((nint)pServerPrincNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<T0>(Silk.NET.Core.Native.IUnknown* pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pServerPrincNamePtr = (byte*) SilkMarshal.StringToPtr(pServerPrincName, NativeStringEncoding.UTF8);
            fixed (void* pAuthInfoPtr = &pAuthInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, byte*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxy, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
            }
            SilkMarshal.Free((nint)pServerPrincNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<T0>(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (void* pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char* pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlanket<T0>(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (char* pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void* pAuthInfoPtr = &pAuthInfo)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, char*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
            var pServerPrincNamePtr = (byte*) SilkMarshal.StringToPtr(pServerPrincName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, byte*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
            SilkMarshal.Free((nint)pServerPrincNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlanket<T0>(ref Silk.NET.Core.Native.IUnknown pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
            var pServerPrincNamePtr = (byte*) SilkMarshal.StringToPtr(pServerPrincName, NativeStringEncoding.UTF8);
                fixed (void* pAuthInfoPtr = &pAuthInfo)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, uint, uint, byte*, uint, uint, void*, uint, int>)@this->LpVtbl[4])(@this, pProxyPtr, dwAuthnSvc, dwAuthzSvc, pServerPrincNamePtr, dwAuthnLevel, dwImpLevel, pAuthInfoPtr, dwCapabilities);
                }
            SilkMarshal.Free((nint)pServerPrincNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy(Silk.NET.Core.Native.IUnknown* pProxy, Silk.NET.Core.Native.IUnknown** ppCopy)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxy, ppCopy);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy(Silk.NET.Core.Native.IUnknown* pProxy, ref Silk.NET.Core.Native.IUnknown* ppCopy)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppCopyPtr = &ppCopy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxy, ppCopyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy(ref Silk.NET.Core.Native.IUnknown pProxy, Silk.NET.Core.Native.IUnknown** ppCopy)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxyPtr, ppCopy);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy(ref Silk.NET.Core.Native.IUnknown pProxy, ref Silk.NET.Core.Native.IUnknown* ppCopy)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pProxyPtr = &pProxy)
            {
                fixed (Silk.NET.Core.Native.IUnknown** ppCopyPtr = &ppCopy)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClientSecurity*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[5])(@this, pProxyPtr, ppCopyPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(Silk.NET.Core.Native.IUnknown* pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket<TI0>(ComPtr<TI0> pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->QueryBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref pAuthnSvc, ref pAuthzSvc, ref pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, uint* pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref Silk.NET.Core.Native.IUnknown pProxy, ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pAuthInfo, ref uint pCapabilites)
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pProxy, ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pAuthInfo, ref pCapabilites);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<T0, TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, char* pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, ref pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, ref pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlanket<T0, TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, ref char pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, ref pServerPrincName, dwAuthnLevel, dwImpLevel, ref pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBlanket<TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, void* pAuthInfo, uint dwCapabilities) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBlanket<T0, TI0>(ComPtr<TI0> pProxy, uint dwAuthnSvc, uint dwAuthzSvc, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pServerPrincName, uint dwAuthnLevel, uint dwImpLevel, ref T0 pAuthInfo, uint dwCapabilities) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetBlanket((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, dwAuthnSvc, dwAuthzSvc, pServerPrincName, dwAuthnLevel, dwImpLevel, ref pAuthInfo, dwCapabilities);
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyProxy<TI0, TI1>(ComPtr<TI0> pProxy, ref ComPtr<TI1> ppCopy) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyProxy((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, (Silk.NET.Core.Native.IUnknown**) ppCopy.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyProxy<TI0>(ComPtr<TI0> pProxy, ref Silk.NET.Core.Native.IUnknown* ppCopy) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyProxy((Silk.NET.Core.Native.IUnknown*) pProxy.Handle, ref ppCopy);
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyProxy<TI0>(ref Silk.NET.Core.Native.IUnknown pProxy, ref ComPtr<TI0> ppCopy) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CopyProxy(ref pProxy, (Silk.NET.Core.Native.IUnknown**) ppCopy.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClientSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
