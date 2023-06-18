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
    [Guid("a8be2ac4-199f-4946-b331-79599fb98de7")]
    [NativeName("Name", "IDXGISwapChain2")]
    public unsafe partial struct IDXGISwapChain2 : IComVtbl<IDXGISwapChain2>, IComVtbl<IDXGISwapChain1>, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<Silk.NET.DXGI.IDXGIDeviceSubObject>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a8be2ac4-199f-4946-b331-79599fb98de7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGISwapChain1(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, IDXGISwapChain1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGISwapChain(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGISwapChain>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIDeviceSubObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGIDeviceSubObject>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGISwapChain2
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
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present(uint SyncInterval, uint Flags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFullscreenState(Silk.NET.Core.Bool32 Fullscreen, IDXGIOutput* pTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResizeTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pNewTargetParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc1(SwapChainDesc1* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenDesc(SwapChainFullscreenDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHwnd(nint* pHwnd)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(Guid* refiid, void** ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present1(uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PresentParameters* pPresentParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsTemporaryMonoSupported()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackgroundColor(D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRotation(ModeRotation Rotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRotation(ModeRotation* pRotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceSize(uint Width, uint Height)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[29])(@this, Width, Height);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(uint* pWidth, uint* pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, int>)@this->LpVtbl[31])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetFrameLatencyWaitableObject()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, void*>)@this->LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMatrixTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatrixTransform(Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrix);
            return ret;
        }

    }
}
