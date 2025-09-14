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
    [Guid("00000026-0000-0000-c000-000000000046")]
    [NativeName("Name", "IUrlMon")]
    public unsafe partial struct IUrlMon : IComVtbl<IUrlMon>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000026-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IUrlMon val)
            => Unsafe.As<IUrlMon, Silk.NET.Core.Native.IUnknown>(ref val);

        public IUrlMon
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
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszTYPEPtr = &pszTYPE)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            fixed (char* pszExtPtr = &pszExt)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            fixed (char* pszCodeBasePtr = &pszCodeBase)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
            fixed (IBindCtx* pbcPtr = &pbc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsid, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                }
            }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPE, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (char* pszCodeBasePtr = &pszCodeBase)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (char* pszCodeBasePtr = &pszCodeBase)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (char* pszCodeBasePtr = &pszCodeBase)
                        {
                            fixed (IBindCtx* pbcPtr = &pbc)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
                        fixed (char* pszCodeBasePtr = &pszCodeBase)
                        {
                            fixed (IBindCtx* pbcPtr = &pbc)
                            {
                                fixed (Guid* riidPtr = &riid)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
                    fixed (char* pszExtPtr = &pszExt)
                    {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (char* pszTYPEPtr = &pszTYPE)
                {
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, char*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
                    fixed (char* pszCodeBasePtr = &pszCodeBase)
                    {
                        fixed (IBindCtx* pbcPtr = &pbc)
                        {
                            fixed (Guid* riidPtr = &riid)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                            }
                        }
                    }
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
                fixed (char* pszExtPtr = &pszExt)
                {
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, char*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
            SilkMarshal.Free((nint)pszCodeBasePtr);
                }
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBase, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
                fixed (char* pszCodeBasePtr = &pszCodeBase)
                {
                    fixed (IBindCtx* pbcPtr = &pbc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, char*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                        }
                    }
                }
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riid, flags);
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, IBindCtx* pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbc, dwClassContext, riidPtr, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, Guid* riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riid, flags);
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ref IBindCtx pbc, uint dwClassContext, ref Guid riid, uint flags)
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
            var pszTYPEPtr = (byte*) SilkMarshal.StringToPtr(pszTYPE, NativeStringEncoding.LPWStr);
            var pszExtPtr = (byte*) SilkMarshal.StringToPtr(pszExt, NativeStringEncoding.LPWStr);
            var pszCodeBasePtr = (byte*) SilkMarshal.StringToPtr(pszCodeBase, NativeStringEncoding.LPWStr);
                fixed (IBindCtx* pbcPtr = &pbc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IUrlMon*, Guid*, byte*, byte*, uint, uint, byte*, IBindCtx*, uint, Guid*, uint, int>)@this->LpVtbl[3])(@this, rclsidPtr, pszTYPEPtr, pszExtPtr, dwFileVersionMS, dwFileVersionLS, pszCodeBasePtr, pbcPtr, dwClassContext, riidPtr, flags);
                    }
                }
            SilkMarshal.Free((nint)pszCodeBasePtr);
            SilkMarshal.Free((nint)pszExtPtr);
            SilkMarshal.Free((nint)pszTYPEPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(Guid* rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, in pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, in pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, in pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, Guid* riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int AsyncGetClassBits<TI0>(ref Guid rclsid, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszTYPE, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszExt, uint dwFileVersionMS, uint dwFileVersionLS, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pszCodeBase, ComPtr<TI0> pbc, uint dwClassContext, ref Guid riid, uint flags) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AsyncGetClassBits(ref rclsid, pszTYPE, pszExt, dwFileVersionMS, dwFileVersionLS, pszCodeBase, (IBindCtx*) pbc.Handle, dwClassContext, ref riid, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IUrlMon*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
