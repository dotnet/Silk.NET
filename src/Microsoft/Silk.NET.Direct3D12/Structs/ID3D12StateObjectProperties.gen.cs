// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void* GetShaderIdentifier(char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                void* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportName);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void* GetShaderIdentifier(ref char pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                void* ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void* GetShaderIdentifier(string pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                void* ret = default;
            var pExportNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pExportName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, byte*, void*>)LpVtbl[3])(@this, pExportNamePtr);
            Marshal.FreeHGlobal((IntPtr)pExportNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe ulong GetShaderStackSize(char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportName);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetShaderStackSize(ref char pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, char*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetShaderStackSize(string pExportName)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            var pExportNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pExportName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, byte*, ulong>)LpVtbl[4])(@this, pExportNamePtr);
            Marshal.FreeHGlobal((IntPtr)pExportNamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly ulong GetPipelineStackSize()
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                ulong ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, ulong>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void SetPipelineStackSize(ulong PipelineStackSizeInBytes)
        {
            var @this = (ID3D12StateObjectProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12StateObjectProperties*, ulong, void>)LpVtbl[6])(@this, PipelineStackSizeInBytes);
        }

    }
}
