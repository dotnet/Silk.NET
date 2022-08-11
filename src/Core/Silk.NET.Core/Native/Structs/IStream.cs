// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Guid("0000000c-0000-0000-C000-000000000046")]
    public unsafe partial struct IStream
    {
        public static readonly Guid Guid = new("0000000c-0000-0000-C000-000000000046");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IStream val)
            => Unsafe.As<IStream, Silk.NET.Core.Native.IUnknown>(ref val);
        public static implicit operator Silk.NET.Core.Native.ISequentialStream(IStream val)
            => Unsafe.As<IStream, Silk.NET.Core.Native.ISequentialStream>(ref val);

        public IStream
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }

        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>) LpVtbl[0])(@this, riid, ppvObject);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riid, ppvObjectPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>) LpVtbl[0])
                    (@this, riidPtr, ppvObject);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    return ((delegate* unmanaged[Cdecl]<IStream*, Guid*, void**, int>) LpVtbl[0])
                        (@this, riidPtr, ppvObjectPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, uint>) LpVtbl[1])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, uint>) LpVtbl[2])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read(void* pv, uint cb, uint* pcbRead)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>) LpVtbl[3])(@this, pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        public readonly int Read(void* pv, uint cb, ref uint pcbRead)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>) LpVtbl[3])(@this, pv, cb, pcbReadPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int Write(void* pv, uint cb, uint* pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>) LpVtbl[4])(@this, pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        public readonly int Write(void* pv, uint cb, ref uint pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, void*, uint, uint*, int>) LpVtbl[4])(@this, pv, cb, pcbWrittenPtr);
            }
        }

        public readonly int Seek(long dlibMove, int dwOrigin, ulong *plibNewPosition)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, long, int, ulong*, int>) LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPosition);
        }

        public readonly int Seek(long dlibMove, int dwOrigin, ref ulong plibNewPosition)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* plibNewPositionPtr = &plibNewPosition)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, long, int, ulong*, int>) LpVtbl[5])(@this, dlibMove, dwOrigin, plibNewPositionPtr);
            }
        }

        public readonly int SetSize(ulong libNewSize)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, ulong, int>) LpVtbl[6])(@this, libNewSize);
        }

        public readonly int CopyTo(IStream* pstm, ulong cb, ulong *pcbRead, ulong *pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ulong, ulong*, ulong*, int>) LpVtbl[7])(@this, pstm, cb, pcbRead, pcbWritten);
        }

        public readonly int CopyTo(ref IStream pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IStream* pstmPtr = &pstm)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ulong, ulong*, ulong*, int>) LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWritten);
            }
        }

        public readonly int CopyTo(ref IStream pstm, ulong cb, ref ulong pcbRead, ulong* pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pcbReadPtr = &pcbRead)
            {
                fixed (IStream* pstmPtr = &pstm)
                {
                    return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ulong, ulong*, ulong*, int>) LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWritten);
                }
            }
        }

        public readonly int CopyTo(ref IStream pstm, ulong cb, ulong* pcbRead, ref ulong pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                fixed (IStream* pstmPtr = &pstm)
                {
                    return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ulong, ulong*, ulong*, int>) LpVtbl[7])(@this, pstmPtr, cb, pcbRead, pcbWrittenPtr);
                }
            }
        }

        public readonly int CopyTo(ref IStream pstm, ulong cb, ref ulong pcbRead, ref ulong pcbWritten)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* pcbWrittenPtr = &pcbWritten)
            {
                fixed (ulong* pcbReadPtr = &pcbRead)
                {
                    fixed (IStream* pstmPtr = &pstm)
                    {
                        return ((delegate* unmanaged[Cdecl]<IStream*, IStream*, ulong, ulong*, ulong*, int>) LpVtbl[7])(@this, pstmPtr, cb, pcbReadPtr, pcbWrittenPtr);
                    }
                }
            }
        }

        public readonly int Commit(uint grfCommitFlags)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, uint, int>) LpVtbl[8])(@this, grfCommitFlags);
        }
        public readonly int Revert()
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, int>) LpVtbl[9])(@this);
        }

        public readonly int LockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, ulong, ulong, uint, int>) LpVtbl[10])(@this, libOffset, cb, dwLockType);
        }

        public readonly int UnlockRegion(ulong libOffset, ulong cb, uint dwLockType)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, ulong, ulong, uint, int>) LpVtbl[11])(@this, libOffset, cb, dwLockType);
        }

        public readonly int Stat(StatSTG* pstatstg, uint grfStatFlag)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, StatSTG*, uint, int>) LpVtbl[12])(@this, pstatstg, grfStatFlag);
        }

        public readonly int Stat(ref StatSTG pstatstg, uint grfStatFlag)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (StatSTG* pstatstgPtr = &pstatstg)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, StatSTG*, uint, int>) LpVtbl[12])(@this, pstatstgPtr, grfStatFlag);
            }
        }

        public readonly int Clone(IStream **ppstm)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            return ((delegate* unmanaged[Cdecl]<IStream*, IStream**, int>) LpVtbl[13])(@this, ppstm);
        }

        public readonly int Clone(ref IStream* ppstm)
        {
            var @this = (IStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IStream** ppstmPtr = &ppstm)
            {
                return ((delegate* unmanaged[Cdecl]<IStream*, IStream**, int>) LpVtbl[13])(@this, ppstmPtr);
            }
        }
    }
}
