// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, byte* pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pParentDataPtr = &pParentData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytes);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppData, pBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytes);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, byte* pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileName, pParentDataPtr, ppDataPtr, pBytesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, ref byte pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
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
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (T0* pParentDataPtr = &pParentData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (T0* pParentDataPtr = &pParentData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (T0* pParentDataPtr = &pParentData)
                {
                    fixed (void** ppDataPtr = &ppData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, ref byte pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (T0* pParentDataPtr = &pParentData)
                {
                    fixed (void** ppDataPtr = &ppData)
                    {
                        fixed (uint* pBytesPtr = &pBytes)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, string pFileName, void* pParentData, void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, string pFileName, void* pParentData, void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, string pFileName, void* pParentData, ref void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, string pFileName, void* pParentData, ref void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                }
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, string pFileName, ref T0 pParentData, void** ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (T0* pParentDataPtr = &pParentData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytes);
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, string pFileName, ref T0 pParentData, void** ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppData, pBytesPtr);
                }
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, string pFileName, ref T0 pParentData, ref void* ppData, uint* pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytes);
                }
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Open<T0>(D3DIncludeType IncludeType, string pFileName, ref T0 pParentData, ref void* ppData, ref uint pBytes) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var pFileNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFileName);
            fixed (T0* pParentDataPtr = &pParentData)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, D3DIncludeType, byte*, T0*, void**, uint*, int>)LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentDataPtr, ppDataPtr, pBytesPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((IntPtr)pFileNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int Close(void* pData)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, void*, int>)LpVtbl[1])(@this, pData);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int Close<T0>(ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DInclude*, T0*, int>)LpVtbl[1])(@this, pDataPtr);
            }
            return ret;
        }

    }
}
