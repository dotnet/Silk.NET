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

namespace Silk.NET.Core.Native
{
    [Guid("a16ee930-d9f6-4222-a514-244473e5d266")]
    [NativeName("Name", "ID3DShaderCacheInstallerClient")]
    public unsafe partial struct ID3DShaderCacheInstallerClient : IComVtbl<ID3DShaderCacheInstallerClient>
    {
        public static readonly Guid Guid = new("a16ee930-d9f6-4222-a514-244473e5d266");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3DShaderCacheInstallerClient
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
        public readonly unsafe int GetInstallerName(nuint* pNameLength, char* pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLength, pName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInstallerName(nuint* pNameLength, ref char pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLength, pNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInstallerName(nuint* pNameLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, byte*, int>)@this->LpVtbl[0])(@this, pNameLength, pNamePtr);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInstallerName(ref nuint pNameLength, char* pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pNameLengthPtr = &pNameLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInstallerName(ref nuint pNameLength, ref char pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pNameLengthPtr = &pNameLength)
            {
                fixed (char* pNamePtr = &pName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, char*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInstallerName(ref nuint pNameLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pNameLengthPtr = &pNameLength)
            {
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, nuint*, byte*, int>)@this->LpVtbl[0])(@this, pNameLengthPtr, pNamePtr);
            SilkMarshal.Free((nint)pNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly D3DShaderCacheAppRegistrationScope GetInstallerScope()
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            D3DShaderCacheAppRegistrationScope ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, D3DShaderCacheAppRegistrationScope>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HandleDriverUpdate(ID3DShaderCacheInstaller* pInstaller)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, ID3DShaderCacheInstaller*, int>)@this->LpVtbl[2])(@this, pInstaller);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HandleDriverUpdate(ref ID3DShaderCacheInstaller pInstaller)
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3DShaderCacheInstaller* pInstallerPtr = &pInstaller)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerClient*, ID3DShaderCacheInstaller*, int>)@this->LpVtbl[2])(@this, pInstallerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HandleDriverUpdate<TI0>(ComPtr<TI0> pInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstaller>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerClient*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->HandleDriverUpdate((ID3DShaderCacheInstaller*) pInstaller.Handle);
        }

    }
}
