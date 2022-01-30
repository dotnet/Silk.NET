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

namespace Silk.NET.Direct3D12
{
    [Guid("de5fa827-9bf9-4f26-89ff-d7f56fde3860")]
    [NativeName("Name", "ID3D12StateObjectProperties")]
    public unsafe partial struct ID3D12StateObjectProperties
    {
        public static readonly Guid Guid = new("de5fa827-9bf9-4f26-89ff-d7f56fde3860");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12StateObjectProperties val)
            => Unsafe.As<ID3D12StateObjectProperties, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12StateObjectProperties
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
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier(char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportName);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportName);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportName);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier(ref char pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportNamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportNamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, byte*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, byte*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, byte*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            }
            #endif
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ulong GetShaderStackSize(char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportName);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportName);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportName);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize(ref char pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12StateObjectProperties*, byte*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, byte*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, byte*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            }
            #endif
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetPipelineStackSize()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineStackSize(ulong PipelineStackSizeInBytes)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12StateObjectProperties*, ulong, void>)LpVtbl[6])(@this, PipelineStackSizeInBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties*, ulong, void>)LpVtbl[6])(@this, PipelineStackSizeInBytes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, ulong, void>)LpVtbl[6])(@this, PipelineStackSizeInBytes);
            }
            #endif
        }

    }
}
