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

namespace Silk.NET.DXGI
{
    [Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84")]
    [NativeName("Name", "IDXGISwapChainMedia")]
    public unsafe partial struct IDXGISwapChainMedia : IComVtbl<IDXGISwapChainMedia>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dd95b90b-f05f-4f6a-bd65-25bfb264bd84");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISwapChainMedia val)
            => Unsafe.As<IDXGISwapChainMedia, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGISwapChainMedia
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
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatisticsMedia(FrameStatisticsMedia* pStats)
        {
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, FrameStatisticsMedia*, int>)@this->LpVtbl[3])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPresentDuration(uint Duration)
        {
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, int>)@this->LpVtbl[4])(@this, Duration);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckPresentDurationSupport(uint DesiredPresentDuration, uint* pClosestSmallerPresentDuration, uint* pClosestLargerPresentDuration)
        {
            var @this = (IDXGISwapChainMedia*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChainMedia*, uint, uint*, uint*, int>)@this->LpVtbl[5])(@this, DesiredPresentDuration, pClosestSmallerPresentDuration, pClosestLargerPresentDuration);
            return ret;
        }

    }
}
