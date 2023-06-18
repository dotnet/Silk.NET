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
        public readonly unsafe void ClientFillBuffer(Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, void>)@this->LpVtbl[4])(@this, uExtent, riid, pDataSize, pDataBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClientNotify(Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, int, void>)@this->LpVtbl[5])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerNotify(Guid* uExtent, Guid* riid, uint cbDataSize, void* pDataBuffer, uint lDataRep)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)@this->LpVtbl[6])(@this, uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerGetSize(Guid* uExtent, Guid* riid, int hrFault, uint* pDataSize)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, int, uint*, void>)@this->LpVtbl[7])(@this, uExtent, riid, hrFault, pDataSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ServerFillBuffer(Guid* uExtent, Guid* riid, uint* pDataSize, void* pDataBuffer, int hrFault)
        {
            var @this = (IChannelHook*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IChannelHook*, Guid*, Guid*, uint*, void*, int, void>)@this->LpVtbl[8])(@this, uExtent, riid, pDataSize, pDataBuffer, hrFault);
        }

    }
}
