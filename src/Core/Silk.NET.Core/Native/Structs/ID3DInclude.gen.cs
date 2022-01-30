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
    [NativeName("Name", "ID3DInclude")]
    public unsafe partial struct ID3DInclude
    {
        public ID3DInclude
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
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBytesPtr = &pBytes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParentDataPtr = &pParentData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytes);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytes);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytes);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytes);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void** ppDataPtr = &ppData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void* pParentDataPtr = &pParentData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void* pParentDataPtr = &pParentData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void* pParentDataPtr = &pParentData)
                {
                    fixed (void** ppDataPtr = &ppData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void* pParentDataPtr = &pParentData)
                {
                    fixed (void** ppDataPtr = &ppData)
                    {
                        fixed (uint* pBytesPtr = &pBytes)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            }
            #endif
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (uint* pBytesPtr = &pBytes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void** ppDataPtr = &ppData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void* pParentDataPtr = &pParentData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                        }
            #endif
                    }
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Close(void* pData)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close<T0>(ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pDataPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
