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
    [Guid("0000013e-0000-0000-c000-000000000046")]
    [NativeName("Name", "IServerSecurity")]
    public unsafe partial struct IServerSecurity : IComVtbl<IServerSecurity>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000013e-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IServerSecurity val)
            => Unsafe.As<IServerSecurity, Silk.NET.Core.Native.IUnknown>(ref val);

        public IServerSecurity
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
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCapabilitiesPtr = &pCapabilities)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pPrivsPtr = &pPrivs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pPrivsPtr = &pPrivs)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pImpLevelPtr = &pImpLevel)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pServerPrincNamePtr = &pServerPrincName)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvc, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (void** pPrivsPtr = &pPrivs)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pImpLevelPtr = &pImpLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (char** pServerPrincNamePtr = &pServerPrincName)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvc, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (void** pPrivsPtr = &pPrivs)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pImpLevelPtr = &pImpLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, char** pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincName, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pCapabilitiesPtr = &pCapabilities)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivs, pCapabilitiesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (void** pPrivsPtr = &pPrivs)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pImpLevelPtr = &pImpLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevel, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilities);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (uint* pCapabilitiesPtr = &pCapabilities)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivs, pCapabilitiesPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pAuthnSvcPtr = &pAuthnSvc)
            {
                fixed (uint* pAuthzSvcPtr = &pAuthzSvc)
                {
                    fixed (char** pServerPrincNamePtr = &pServerPrincName)
                    {
                        fixed (uint* pAuthnLevelPtr = &pAuthnLevel)
                        {
                            fixed (void** pPrivsPtr = &pPrivs)
                            {
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevel, pPrivsPtr, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilities);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivs, pCapabilitiesPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                fixed (void** pPrivsPtr = &pPrivs)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilities);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, ref char* pServerPrincName, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
                                fixed (void** pPrivsPtr = &pPrivs)
                                {
                                    fixed (uint* pCapabilitiesPtr = &pCapabilities)
                                    {
                                        ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, uint*, uint*, char**, uint*, uint*, void**, uint*, int>)@this->LpVtbl[3])(@this, pAuthnSvcPtr, pAuthzSvcPtr, pServerPrincNamePtr, pAuthnLevelPtr, pImpLevelPtr, pPrivsPtr, pCapabilitiesPtr);
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
        public readonly int ImpersonateClient()
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevertToSelf()
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsImpersonating()
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IServerSecurity*, Silk.NET.Core.Bool32>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(uint* pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, uint* pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, uint* pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, uint* pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, void** pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, uint* pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryBlanket(ref uint pAuthnSvc, ref uint pAuthzSvc, string[] pServerPrincNameSa, ref uint pAuthnLevel, ref uint pImpLevel, ref void* pPrivs, ref uint pCapabilities)
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pServerPrincName = (char**) SilkMarshal.StringArrayToPtr(pServerPrincNameSa);
            var ret = @this->QueryBlanket(ref pAuthnSvc, ref pAuthzSvc, pServerPrincName, ref pAuthnLevel, ref pImpLevel, ref pPrivs, ref pCapabilities);
            SilkMarshal.CopyPtrToStringArray((nint) pServerPrincName, pServerPrincNameSa);
            SilkMarshal.Free((nint) pServerPrincName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IServerSecurity*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
