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
    [Guid("0000010b-0000-0000-c000-000000000046")]
    [NativeName("Name", "IPersistFile")]
    public unsafe partial struct IPersistFile : IComVtbl<IPersistFile>, IComVtbl<IPersist>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000010b-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IPersist(IPersistFile val)
            => Unsafe.As<IPersistFile, IPersist>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPersistFile val)
            => Unsafe.As<IPersistFile, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPersistFile
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
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassID(Guid* pClassID)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassID(ref Guid pClassID)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pClassIDPtr = &pClassID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDirty()
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName, uint dwMode)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, uint, int>)@this->LpVtbl[5])(@this, pszFileName, dwMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName, uint dwMode)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszFileNamePtr = &pszFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, uint, int>)@this->LpVtbl[5])(@this, pszFileNamePtr, dwMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName, uint dwMode)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, uint, int>)@this->LpVtbl[5])(@this, pszFileNamePtr, dwMode);
            SilkMarshal.Free((nint)pszFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Save([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName, Silk.NET.Core.Bool32 fRemember)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileName, fRemember);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName, Silk.NET.Core.Bool32 fRemember)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszFileNamePtr = &pszFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileNamePtr, fRemember);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Save([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName, Silk.NET.Core.Bool32 fRemember)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pszFileNamePtr, fRemember);
            SilkMarshal.Free((nint)pszFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SaveCompleted([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pszFileName)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, int>)@this->LpVtbl[7])(@this, pszFileName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveCompleted([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pszFileName)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pszFileNamePtr = &pszFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char*, int>)@this->LpVtbl[7])(@this, pszFileNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SaveCompleted([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszFileName)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pszFileNamePtr = (byte*) SilkMarshal.StringToPtr(pszFileName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, byte*, int>)@this->LpVtbl[7])(@this, pszFileNamePtr);
            SilkMarshal.Free((nint)pszFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurFile(char** ppszFileName)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char**, int>)@this->LpVtbl[8])(@this, ppszFileName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurFile(ref char* ppszFileName)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppszFileNamePtr = &ppszFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPersistFile*, char**, int>)@this->LpVtbl[8])(@this, ppszFileNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCurFile(string[] ppszFileNameSa)
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppszFileName = (char**) SilkMarshal.StringArrayToPtr(ppszFileNameSa);
            var ret = @this->GetCurFile(ppszFileName);
            SilkMarshal.CopyPtrToStringArray((nint) ppszFileName, ppszFileNameSa);
            SilkMarshal.Free((nint) ppszFileName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPersistFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
