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
    [Guid("d8f2f5e6-6102-4863-9f26-389a4676efde")]
    [NativeName("Name", "IMarshalingStream")]
    public unsafe partial struct IMarshalingStream
    {
        public static readonly Guid Guid = new("d8f2f5e6-6102-4863-9f26-389a4676efde");

        public static implicit operator Silk.NET.Core.Win32Extras.IStream(IMarshalingStream val)
            => Unsafe.As<IMarshalingStream, Silk.NET.Core.Win32Extras.IStream>(ref val);

        public static implicit operator ISequentialStream(IMarshalingStream val)
            => Unsafe.As<IMarshalingStream, ISequentialStream>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMarshalingStream val)
            => Unsafe.As<IMarshalingStream, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMarshalingStream
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
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(void* pv, uint cb, uint* pcbRead)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[3])(@this, pv, cb, pcbRead);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read(void* pv, uint cb, ref uint pcbRead)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[3])(@this, pv, cb, pcbReadPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Read<T0>(ref T0 pv, uint cb, uint* pcbRead) where T0 : unmanaged
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[3])(@this, pvPtr, cb, pcbRead);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Read<T0>(ref T0 pv, uint cb, ref uint pcbRead) where T0 : unmanaged
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[3])(@this, pvPtr, cb, pcbReadPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write(void* pv, uint cb, uint* pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[4])(@this, pv, cb, pcbWritten);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write(void* pv, uint cb, ref uint pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Write<T0>(ref T0 pv, uint cb, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[4])(@this, pvPtr, cb, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Write<T0>(ref T0 pv, uint cb, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, void*, uint, uint*, int>)LpVtbl[4])(@this, pvPtr, cb, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Seek(long dlibMove, uint dwOrigin, ulong* plibNewPosition)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, long, uint, ulong*, int>)LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPosition);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Seek(long dlibMove, uint dwOrigin, ref ulong plibNewPosition)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* plibNewPositionPtr = &plibNewPosition)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, long, uint, ulong*, int>)LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPositionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSize(ulong libNewSize)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, ulong, int>)LpVtbl[6])(@this, libNewSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWritten);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWrittenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                fixed (ulong* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstm, cb, pcbReadPtr, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
            {
                fixed (ulong* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyTo(ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
            {
                fixed (ulong* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWritten);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyTo(ref Silk.NET.Core.Win32Extras.IStream pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pstmPtr = &pstm)
            {
                fixed (ulong* pcbReadPtr = &pcbRead)
                {
                    fixed (ulong* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream*, ulong, ulong*, ulong*, int>)LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWrittenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit(uint grfCommitFlags)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, uint, int>)LpVtbl[8])(@this, grfCommitFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Revert()
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, ulong, ulong, uint, int>)LpVtbl[10])(@this, libOffset, cb, dwLockType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, ulong, ulong, uint, int>)LpVtbl[11])(@this, libOffset, cb, dwLockType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Stat(TagSTATSTG* pstatstg, uint grfStatFlag)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, TagSTATSTG*, uint, int>)LpVtbl[12])(@this, pstatstg, grfStatFlag);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Stat(ref TagSTATSTG pstatstg, uint grfStatFlag)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TagSTATSTG* pstatstgPtr = &pstatstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, TagSTATSTG*, uint, int>)LpVtbl[12])(@this, pstatstgPtr, grfStatFlag);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(Silk.NET.Core.Win32Extras.IStream** ppstm)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream**, int>)LpVtbl[13])(@this, ppstm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref Silk.NET.Core.Win32Extras.IStream* ppstm)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream** ppstmPtr = &ppstm)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, Silk.NET.Core.Win32Extras.IStream**, int>)LpVtbl[13])(@this, ppstmPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalingContextAttribute(COMarshalingContextAttributes attribute, nuint* pAttributeValue)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, COMarshalingContextAttributes, nuint*, int>)LpVtbl[14])(@this, attribute, pAttributeValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMarshalingContextAttribute(COMarshalingContextAttributes attribute, ref nuint pAttributeValue)
        {
            var @this = (IMarshalingStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nuint* pAttributeValuePtr = &pAttributeValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshalingStream*, COMarshalingContextAttributes, nuint*, int>)LpVtbl[14])(@this, attribute, pAttributeValuePtr);
            }
            return ret;
        }

    }
}
