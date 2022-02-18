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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c")]
    [NativeName("Name", "IDxcIncludeHandler")]
    public unsafe partial struct IDxcIncludeHandler
    {
        public static readonly Guid Guid = new("7f61fc7d-950d-467f-b3e3-3c02fb49187c");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcIncludeHandler val)
            => Unsafe.As<IDxcIncludeHandler, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcIncludeHandler
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
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource(char* pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSource);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource(char* pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource(ref char pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFilenamePtr = &pFilename)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource(ref char pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFilenamePtr = &pFilename)
            {
                fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            }
            #endif
            SilkMarshal.Free((nint)pFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
            fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFilenamePtr);
            return ret;
        }

    }
}
