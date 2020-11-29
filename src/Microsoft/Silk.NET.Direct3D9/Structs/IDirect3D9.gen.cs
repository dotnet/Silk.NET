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

namespace Silk.NET.Direct3D9
{
    [Guid("81bdcbca-64d4-426d-ae8d-ad0147f4275c")]
    [NativeName("Name", "IDirect3D9")]
    public unsafe partial struct IDirect3D9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3D9 val)
            => Unsafe.As<IDirect3D9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3D9
        (
            char* version = null,
            void** lpVtbl = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version;
            }

            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Version")]
        public char* Version;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int RegisterSoftwareDevice(void* pInitializeFunction)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, void*, int>)LpVtbl[3])(@this, pInitializeFunction);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int RegisterSoftwareDevice<T0>(ref T0 pInitializeFunction) where T0 : unmanaged
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (T0* pInitializeFunctionPtr = &pInitializeFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, T0*, int>)LpVtbl[3])(@this, pInitializeFunctionPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetAdapterCount()
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetAdapterIdentifier(uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetAdapterIdentifier(uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint GetAdapterModeCount(uint Adapter, Format Format)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint>)LpVtbl[6])(@this, Adapter, Format);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int EnumAdapterModes(uint Adapter, Format Format, uint Mode, Displaymode* pMode)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int EnumAdapterModes(uint Adapter, Format Format, uint Mode, ref Displaymode pMode)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetAdapterDisplayMode(uint Adapter, Displaymode* pMode)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pMode);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetAdapterDisplayMode(uint Adapter, ref Displaymode pMode)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pModePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckDeviceType(uint iAdapter, Devtype DevType, Format DisplayFormat, Format BackBufferFormat, int bWindowed)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, int, int>)LpVtbl[9])(@this, iAdapter, DevType, DisplayFormat, BackBufferFormat, bWindowed);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckDeviceFormat(uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, uint, Resourcetype, Format, int>)LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, uint* pQualityLevels)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pQualityLevelsPtr = &pQualityLevels)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckDepthStencilMatch(uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, Format, int>)LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int CheckDeviceFormatConversion(uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Format, Format, int>)LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDeviceCaps(uint Adapter, Devtype DeviceType, Caps9* pCaps)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetDeviceCaps(uint Adapter, Devtype DeviceType, ref Caps9 pCaps)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly IntPtr GetAdapterMonitor(uint Adapter)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                IntPtr ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, IntPtr>)LpVtbl[15])(@this, Adapter);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
                }
            }
            return ret;
        }

    }
}
