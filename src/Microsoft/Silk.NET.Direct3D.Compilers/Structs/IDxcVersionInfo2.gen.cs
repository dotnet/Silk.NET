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
    [Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83")]
    [NativeName("Name", "IDxcVersionInfo2")]
    public unsafe partial struct IDxcVersionInfo2 : IComVtbl<IDxcVersionInfo2>, IComVtbl<IDxcVersionInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fb6904c4-42f0-4b62-9c46-983af7da7c83");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint* pMajor, uint* pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint* pMajor, ref uint pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMinorPtr = &pMinor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(ref uint pMajor, uint* pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMajorPtr = &pMajor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(ref uint pMajor, ref uint pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMajorPtr = &pMajor)
            {
                fixed (uint* pMinorPtr = &pMinor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajorPtr, pMinorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlags(uint* pFlags)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)@this->LpVtbl[4])(@this, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlags(ref uint pFlags)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)@this->LpVtbl[4])(@this, pFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, byte** pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCount, pCommitHash);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, ref byte* pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** pCommitHashPtr = &pCommitHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCount, pCommitHashPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(ref uint pCommitCount, byte** pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCommitCountPtr = &pCommitCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCountPtr, pCommitHash);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(ref uint pCommitCount, ref byte* pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCommitCountPtr = &pCommitCount)
            {
                fixed (byte** pCommitHashPtr = &pCommitHash)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCountPtr, pCommitHashPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, string[] pCommitHashSa)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pCommitHash = (byte**) SilkMarshal.StringArrayToPtr(pCommitHashSa);
            var ret = @this->GetCommitInfo(pCommitCount, pCommitHash);
            SilkMarshal.CopyPtrToStringArray((nint) pCommitHash, pCommitHashSa);
            SilkMarshal.Free((nint) pCommitHash);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCommitInfo(ref uint pCommitCount, string[] pCommitHashSa)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pCommitHash = (byte**) SilkMarshal.StringArrayToPtr(pCommitHashSa);
            var ret = @this->GetCommitInfo(ref pCommitCount, pCommitHash);
            SilkMarshal.CopyPtrToStringArray((nint) pCommitHash, pCommitHashSa);
            SilkMarshal.Free((nint) pCommitHash);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
