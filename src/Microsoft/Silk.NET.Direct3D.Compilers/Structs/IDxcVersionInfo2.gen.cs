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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83")]
    [NativeName("Name", "IDxcVersionInfo2")]
    public unsafe partial struct IDxcVersionInfo2
    {
        public static implicit operator IDxcVersionInfo(IDxcVersionInfo2 val)
            => Unsafe.As<IDxcVersionInfo2, IDxcVersionInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcVersionInfo2 val)
            => Unsafe.As<IDxcVersionInfo2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcVersionInfo2
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
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVersion(uint* pMajor, uint* pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int>)LpVtbl[3])(@this, pMajor, pMinor);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVersion(uint* pMajor, ref uint pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pMinorPtr = &pMinor)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int>)LpVtbl[3])(@this, pMajor, pMinorPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetVersion(ref uint pMajor, uint* pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pMajorPtr = &pMajor)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int>)LpVtbl[3])(@this, pMajorPtr, pMinor);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetVersion(ref uint pMajor, ref uint pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pMajorPtr = &pMajor)
            {
                fixed (uint* pMinorPtr = &pMinor)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, uint*, int>)LpVtbl[3])(@this, pMajorPtr, pMinorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetFlags(uint* pFlags)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, int>)LpVtbl[4])(@this, pFlags);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetFlags(ref uint pFlags)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, int>)LpVtbl[4])(@this, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, byte** pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, byte**, int>)LpVtbl[5])(@this, pCommitCount, pCommitHash);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, ref byte* pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (byte** pCommitHashPtr = &pCommitHash)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, byte**, int>)LpVtbl[5])(@this, pCommitCount, pCommitHashPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCommitInfo(ref uint pCommitCount, byte** pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pCommitCountPtr = &pCommitCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, byte**, int>)LpVtbl[5])(@this, pCommitCountPtr, pCommitHash);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetCommitInfo(ref uint pCommitCount, ref byte* pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pCommitCountPtr = &pCommitCount)
            {
                fixed (byte** pCommitHashPtr = &pCommitHash)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo2*, uint*, byte**, int>)LpVtbl[5])(@this, pCommitCountPtr, pCommitHashPtr);
                }
            }
            return ret;
        }

    }
}
