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
    [Guid("76a3e735-02df-4a12-98eb-043ad3600af3")]
    [NativeName("Name", "ITypeLibRegistration")]
    public unsafe partial struct ITypeLibRegistration : IComVtbl<ITypeLibRegistration>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("76a3e735-02df-4a12-98eb-043ad3600af3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ITypeLibRegistration val)
            => Unsafe.As<ITypeLibRegistration, Silk.NET.Core.Native.IUnknown>(ref val);

        public ITypeLibRegistration
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
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGuid(Guid* pGuid)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, int>)@this->LpVtbl[3])(@this, pGuid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGuid(ref Guid pGuid)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pGuidPtr = &pGuid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, Guid*, int>)@this->LpVtbl[3])(@this, pGuidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(char** pVersion)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[4])(@this, pVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(ref char* pVersion)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pVersionPtr = &pVersion)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[4])(@this, pVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLcid(uint* pLcid)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[5])(@this, pLcid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLcid(ref uint pLcid)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pLcidPtr = &pLcid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[5])(@this, pLcidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWin32Path(char** pWin32Path)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[6])(@this, pWin32Path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWin32Path(ref char* pWin32Path)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pWin32PathPtr = &pWin32Path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[6])(@this, pWin32PathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWin64Path(char** pWin64Path)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[7])(@this, pWin64Path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWin64Path(ref char* pWin64Path)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pWin64PathPtr = &pWin64Path)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[7])(@this, pWin64PathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(char** pDisplayName)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[8])(@this, pDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayName(ref char* pDisplayName)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pDisplayNamePtr = &pDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[8])(@this, pDisplayNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlags(uint* pFlags)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[9])(@this, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlags(ref uint pFlags)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, uint*, int>)@this->LpVtbl[9])(@this, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHelpDir(char** pHelpDir)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[10])(@this, pHelpDir);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHelpDir(ref char* pHelpDir)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pHelpDirPtr = &pHelpDir)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeLibRegistration*, char**, int>)@this->LpVtbl[10])(@this, pHelpDirPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(string[] pVersionSa)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pVersion = (char**) SilkMarshal.StringArrayToPtr(pVersionSa);
            var ret = @this->GetVersion(pVersion);
            SilkMarshal.CopyPtrToStringArray((nint) pVersion, pVersionSa);
            SilkMarshal.Free((nint) pVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWin32Path(string[] pWin32PathSa)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pWin32Path = (char**) SilkMarshal.StringArrayToPtr(pWin32PathSa);
            var ret = @this->GetWin32Path(pWin32Path);
            SilkMarshal.CopyPtrToStringArray((nint) pWin32Path, pWin32PathSa);
            SilkMarshal.Free((nint) pWin32Path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWin64Path(string[] pWin64PathSa)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pWin64Path = (char**) SilkMarshal.StringArrayToPtr(pWin64PathSa);
            var ret = @this->GetWin64Path(pWin64Path);
            SilkMarshal.CopyPtrToStringArray((nint) pWin64Path, pWin64PathSa);
            SilkMarshal.Free((nint) pWin64Path);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayName(string[] pDisplayNameSa)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pDisplayName = (char**) SilkMarshal.StringArrayToPtr(pDisplayNameSa);
            var ret = @this->GetDisplayName(pDisplayName);
            SilkMarshal.CopyPtrToStringArray((nint) pDisplayName, pDisplayNameSa);
            SilkMarshal.Free((nint) pDisplayName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHelpDir(string[] pHelpDirSa)
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pHelpDir = (char**) SilkMarshal.StringArrayToPtr(pHelpDirSa);
            var ret = @this->GetHelpDir(pHelpDir);
            SilkMarshal.CopyPtrToStringArray((nint) pHelpDir, pHelpDirSa);
            SilkMarshal.Free((nint) pHelpDir);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeLibRegistration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
