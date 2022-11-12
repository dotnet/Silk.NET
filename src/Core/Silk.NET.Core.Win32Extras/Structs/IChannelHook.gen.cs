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
    [Guid("1008c4a0-7613-11cf-9af1-0020af6e72f4")]
    [NativeName("Name", "IChannelHook")]
    public unsafe partial struct IChannelHook : IComVtbl<IChannelHook>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1008c4a0-7613-11cf-9af1-0020af6e72f4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IChannelHook val)
            => Unsafe.As<IChannelHook, Silk.NET.Core.Native.IUnknown>(ref val);

        public IChannelHook
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
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IChannelHook*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(Guid* uExtent, Guid* riid, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riid, pDataSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(Guid* uExtent, Guid* riid, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riid, pDataSizePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(Guid* uExtent, ref Guid riid, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riidPtr, pDataSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(Guid* uExtent, ref Guid riid, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtent, riidPtr, pDataSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(ref Guid uExtent, Guid* riid, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riid, pDataSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(ref Guid uExtent, Guid* riid, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riid, pDataSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientGetSize(ref Guid uExtent, ref Guid riid, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riidPtr, pDataSize);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClientGetSize(ref Guid uExtent, ref Guid riid, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void>)@this->LpVtbl[3])(@this, uExtentPtr, riidPtr, pDataSizePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(Guid* uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBufferPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(Guid* uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSizePtr, pDataBuffer);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(Guid* uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSizePtr, pDataBufferPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(Guid* uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSize, pDataBuffer);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(Guid* uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSize, pDataBufferPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(Guid* uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSizePtr, pDataBuffer);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(Guid* uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riidPtr, pDataSizePtr, pDataBufferPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(ref Guid uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSize, pDataBuffer);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(ref Guid uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSize, pDataBufferPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(ref Guid uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSizePtr, pDataBuffer);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(ref Guid uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riid, pDataSizePtr, pDataBufferPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(ref Guid uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSize, pDataBuffer);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer<T0>(ref Guid uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSize, pDataBufferPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientFillBuffer(ref Guid uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBuffer);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClientFillBuffer<T0>(ref Guid uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (void* pDataBufferPtr = &pDataBuffer)
                        {
                            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBufferPtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify(Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify<T0>(Guid* uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify(Guid* uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riidPtr, cbDataSize, pDataBuffer, lDataRep, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify<T0>(Guid* uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riidPtr, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify(ref Guid uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify<T0>(ref Guid uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riid, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify(ref Guid uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBuffer, lDataRep, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClientNotify<T0>(ref Guid uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBufferPtr, lDataRep, hrFault);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify(Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify<T0>(Guid* uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBufferPtr, lDataRep);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify(Guid* uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riidPtr, cbDataSize, pDataBuffer, lDataRep);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify<T0>(Guid* uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riidPtr, cbDataSize, pDataBufferPtr, lDataRep);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify(ref Guid uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riid, cbDataSize, pDataBuffer, lDataRep);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify<T0>(ref Guid uExtent, Guid* riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riid, cbDataSize, pDataBufferPtr, lDataRep);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify(ref Guid uExtent, ref Guid riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBuffer, lDataRep);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ServerNotify<T0>(ref Guid uExtent, ref Guid riid, uint cbDataSize, ref T0 pDataBuffer, uint lDataRep) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtentPtr, riidPtr, cbDataSize, pDataBufferPtr, lDataRep);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(Guid* uExtent, Guid* riid, int hrFault, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(Guid* uExtent, Guid* riid, int hrFault, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSizePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(Guid* uExtent, ref Guid riid, int hrFault, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riidPtr, hrFault, pDataSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(Guid* uExtent, ref Guid riid, int hrFault, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riidPtr, hrFault, pDataSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(ref Guid uExtent, Guid* riid, int hrFault, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riid, hrFault, pDataSize);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(ref Guid uExtent, Guid* riid, int hrFault, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riid, hrFault, pDataSizePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(ref Guid uExtent, ref Guid riid, int hrFault, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riidPtr, hrFault, pDataSize);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ServerGetSize(ref Guid uExtent, ref Guid riid, int hrFault, ref uint pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtentPtr, riidPtr, hrFault, pDataSizePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(Guid* uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataBufferPtr = &pDataBuffer)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBufferPtr, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(Guid* uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSizePtr, pDataBuffer, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(Guid* uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSizePtr, pDataBufferPtr, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(Guid* uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSize, pDataBuffer, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(Guid* uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSize, pDataBufferPtr, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(Guid* uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSizePtr, pDataBuffer, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(Guid* uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* riidPtr = &riid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riidPtr, pDataSizePtr, pDataBufferPtr, hrFault);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(ref Guid uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSize, pDataBuffer, hrFault);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(ref Guid uExtent, Guid* riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (void* pDataBufferPtr = &pDataBuffer)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSize, pDataBufferPtr, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(ref Guid uExtent, Guid* riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSizePtr, pDataBuffer, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(ref Guid uExtent, Guid* riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riid, pDataSizePtr, pDataBufferPtr, hrFault);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(ref Guid uExtent, ref Guid riid, uint* pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSize, pDataBuffer, hrFault);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer<T0>(ref Guid uExtent, ref Guid riid, uint* pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void* pDataBufferPtr = &pDataBuffer)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSize, pDataBufferPtr, hrFault);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(ref Guid uExtent, ref Guid riid, ref uint pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBuffer, hrFault);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ServerFillBuffer<T0>(ref Guid uExtent, ref Guid riid, ref uint pDataSize, ref T0 pDataBuffer, int hrFault) where T0 : unmanaged
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Guid* uExtentPtr = &uExtent)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (void* pDataBufferPtr = &pDataBuffer)
                        {
                            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtentPtr, riidPtr, pDataSizePtr, pDataBufferPtr, hrFault);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
