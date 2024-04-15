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

namespace Silk.NET.Direct3D9
{
    [Guid("02177241-69fc-400c-8ff1-93a44df6861d")]
    [NativeName("Name", "IDirect3D9Ex")]
    public unsafe partial struct IDirect3D9Ex : IComVtbl<IDirect3D9Ex>, IComVtbl<IDirect3D9>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("02177241-69fc-400c-8ff1-93a44df6861d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDirect3D9(IDirect3D9Ex val)
            => Unsafe.As<IDirect3D9Ex, IDirect3D9>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3D9Ex val)
            => Unsafe.As<IDirect3D9Ex, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3D9Ex
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
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterSoftwareDevice(void* pInitializeFunction)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunction);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterSoftwareDevice<T0>(ref T0 pInitializeFunction) where T0 : unmanaged
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInitializeFunctionPtr = &pInitializeFunction)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, void*, int>)@this->LpVtbl[3])(@this, pInitializeFunctionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterCount()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterIdentifier(uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterIdentifier(uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)@this->LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterModeCount(uint Adapter, Format Format)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint>)@this->LpVtbl[6])(@this, Adapter, Format);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModes(uint Adapter, Format Format, uint Mode, Displaymode* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapterModes(uint Adapter, Format Format, uint Mode, ref Displaymode pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)@this->LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayMode(uint Adapter, Displaymode* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterDisplayMode(uint Adapter, ref Displaymode pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymode*, int>)@this->LpVtbl[8])(@this, Adapter, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceType(uint Adapter, Devtype DevType, Format AdapterFormat, Format BackBufferFormat, Silk.NET.Core.Bool32 bWindowed)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, Silk.NET.Core.Bool32, int>)@this->LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceFormat(uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, uint, Resourcetype, Format, int>)@this->LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, Silk.NET.Core.Bool32 Windowed, MultisampleType MultiSampleType, uint* pQualityLevels)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Silk.NET.Core.Bool32, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, Silk.NET.Core.Bool32 Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pQualityLevelsPtr = &pQualityLevels)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Silk.NET.Core.Bool32, MultisampleType, uint*, int>)@this->LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDepthStencilMatch(uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, Format, int>)@this->LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceFormatConversion(uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, int>)@this->LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceCaps(uint Adapter, Devtype DeviceType, Caps9* pCaps)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceCaps(uint Adapter, Devtype DeviceType, ref Caps9 pCaps)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)@this->LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nint GetAdapterMonitor(uint Adapter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, nint>)@this->LpVtbl[15])(@this, Adapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)@this->LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetAdapterModeCountEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Displaymodefilter* pFilter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)@this->LpVtbl[17])(@this, Adapter, pFilter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterModeCountEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Displaymodefilter pFilter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)@this->LpVtbl[17])(@this, Adapter, pFilterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Displaymodefilter* pFilter, uint Mode, Displaymodeex* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)@this->LpVtbl[18])(@this, Adapter, pFilter, Mode, pMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Displaymodefilter* pFilter, uint Mode, ref Displaymodeex pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)@this->LpVtbl[18])(@this, Adapter, pFilter, Mode, pModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Displaymodefilter pFilter, uint Mode, Displaymodeex* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)@this->LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pMode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapterModesEx(uint Adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Displaymodefilter pFilter, uint Mode, ref Displaymodeex pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
                fixed (Displaymodeex* pModePtr = &pMode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)@this->LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pModePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayModeEx(uint Adapter, Displaymodeex* pMode, Displayrotation* pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[19])(@this, Adapter, pMode, pRotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayModeEx(uint Adapter, Displaymodeex* pMode, ref Displayrotation pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displayrotation* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[19])(@this, Adapter, pMode, pRotationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayModeEx(uint Adapter, ref Displaymodeex pMode, Displayrotation* pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[19])(@this, Adapter, pModePtr, pRotation);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterDisplayModeEx(uint Adapter, ref Displaymodeex pMode, ref Displayrotation pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
                fixed (Displayrotation* pRotationPtr = &pRotation)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)@this->LpVtbl[19])(@this, Adapter, pModePtr, pRotationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, ref IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9Ex** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, ref IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
            {
                fixed (IDirect3DDevice9Ex** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, ref IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (IDirect3DDevice9Ex** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, ref IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
            {
                fixed (Displaymodeex* pFullscreenDisplayModePtr = &pFullscreenDisplayMode)
                {
                    fixed (IDirect3DDevice9Ex** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)@this->LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterLUID(uint Adapter, Luid* pLUID)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Luid*, int>)@this->LpVtbl[21])(@this, Adapter, pLUID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterLUID(uint Adapter, ref Luid pLUID)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Luid* pLUIDPtr = &pLUID)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Luid*, int>)@this->LpVtbl[21])(@this, Adapter, pLUIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, (IDirect3DDevice9**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDevice<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters, (IDirect3DDevice9**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9Ex>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, (IDirect3DDevice9Ex**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9Ex>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ref pFullscreenDisplayMode, (IDirect3DDevice9Ex**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9Ex>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters, pFullscreenDisplayMode, (IDirect3DDevice9Ex**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDeviceEx<TI0>(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref Displaymodeex pFullscreenDisplayMode, ref ComPtr<TI0> ppReturnedDeviceInterface) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9Ex>, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDeviceEx(Adapter, DeviceType, hFocusWindow, BehaviorFlags, ref pPresentationParameters, ref pFullscreenDisplayMode, (IDirect3DDevice9Ex**) ppReturnedDeviceInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
