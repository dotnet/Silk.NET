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
    public unsafe partial struct IDirect3D9Ex
    {
        public static readonly Guid Guid = new("02177241-69fc-400c-8ff1-93a44df6861d");

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterSoftwareDevice(void* pInitializeFunction)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunction);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunction);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunction);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterSoftwareDevice<T0>(ref T0 pInitializeFunction) where T0 : unmanaged
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInitializeFunctionPtr = &pInitializeFunction)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunctionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunctionPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, void*, int>)LpVtbl[3])(@this, pInitializeFunctionPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterCount()
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterIdentifier(uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterIdentifier(uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterModeCount(uint Adapter, Format Format)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Format, uint>)LpVtbl[6])(@this, Adapter, Format);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Format, uint>)LpVtbl[6])(@this, Adapter, Format);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint>)LpVtbl[6])(@this, Adapter, Format);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModes(uint Adapter, Format Format, uint Mode, Displaymode* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapterModes(uint Adapter, Format Format, uint Mode, ref Displaymode pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayMode(uint Adapter, Displaymode* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pMode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pMode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pMode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterDisplayMode(uint Adapter, ref Displaymode pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymode* pModePtr = &pMode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pModePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pModePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pModePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceType(uint Adapter, Devtype DevType, Format AdapterFormat, Format BackBufferFormat, int bWindowed)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, Format, int, int>)LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, Format, int, int>)LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, int, int>)LpVtbl[9])(@this, Adapter, DevType, AdapterFormat, BackBufferFormat, bWindowed);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceFormat(uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, uint, Resourcetype, Format, int>)LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, uint, Resourcetype, Format, int>)LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, uint, Resourcetype, Format, int>)LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, uint* pQualityLevels)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pQualityLevelsPtr = &pQualityLevels)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDepthStencilMatch(uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, Format, Format, int>)LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, Format, Format, int>)LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, Format, int>)LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceFormatConversion(uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Format, Format, int>)LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Format, Format, int>)LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Format, Format, int>)LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceCaps(uint Adapter, Devtype DeviceType, Caps9* pCaps)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceCaps(uint Adapter, Devtype DeviceType, ref Caps9 pCaps)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Caps9* pCapsPtr = &pCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nint GetAdapterMonitor(uint Adapter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, nint>)LpVtbl[15])(@this, Adapter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, nint>)LpVtbl[15])(@this, Adapter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, nint>)LpVtbl[15])(@this, Adapter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetAdapterModeCountEx(uint Adapter, Displaymodefilter* pFilter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilter);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilter);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilter);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetAdapterModeCountEx(uint Adapter, ref Displaymodefilter pFilter)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilterPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilterPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint>)LpVtbl[17])(@this, Adapter, pFilterPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, Displaymodefilter* pFilter, uint Mode, Displaymodeex* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pMode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pMode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pMode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, Displaymodefilter* pFilter, uint Mode, ref Displaymodeex pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pModePtr = &pMode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pModePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pModePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilter, Mode, pModePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumAdapterModesEx(uint Adapter, ref Displaymodefilter pFilter, uint Mode, Displaymodeex* pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pMode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pMode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pMode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumAdapterModesEx(uint Adapter, ref Displaymodefilter pFilter, uint Mode, ref Displaymodeex pMode)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodefilter* pFilterPtr = &pFilter)
            {
                fixed (Displaymodeex* pModePtr = &pMode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pModePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pModePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodefilter*, uint, Displaymodeex*, int>)LpVtbl[18])(@this, Adapter, pFilterPtr, Mode, pModePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayModeEx(uint Adapter, Displaymodeex* pMode, Displayrotation* pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotation);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotation);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapterDisplayModeEx(uint Adapter, Displaymodeex* pMode, ref Displayrotation pRotation)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displayrotation* pRotationPtr = &pRotation)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotationPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pMode, pRotationPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotation);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotation);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotationPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotationPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Displaymodeex*, Displayrotation*, int>)LpVtbl[19])(@this, Adapter, pModePtr, pRotationPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, IDirect3DDevice9Ex** ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDeviceEx(uint Adapter, Devtype DeviceType, nint hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, Displaymodeex* pFullscreenDisplayMode, ref IDirect3DDevice9Ex* ppReturnedDeviceInterface)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9Ex** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterface);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterface);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterface);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayMode, ppReturnedDeviceInterfacePtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterface);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Devtype, nint, uint, PresentParameters*, Displaymodeex*, IDirect3DDevice9Ex**, int>)LpVtbl[20])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, pFullscreenDisplayModePtr, ppReturnedDeviceInterfacePtr);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUID);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUID);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUID);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAdapterLUID(uint Adapter, ref Luid pLUID)
        {
            var @this = (IDirect3D9Ex*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Luid* pLUIDPtr = &pLUID)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUIDPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUIDPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9Ex*, uint, Luid*, int>)LpVtbl[21])(@this, Adapter, pLUIDPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
