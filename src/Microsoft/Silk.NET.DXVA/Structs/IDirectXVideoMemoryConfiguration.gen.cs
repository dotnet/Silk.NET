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

namespace Silk.NET.DXVA
{
    [Guid("b7f916dd-db3b-49c1-84d7-e45ef99ec726")]
    [NativeName("Name", "IDirectXVideoMemoryConfiguration")]
    public unsafe partial struct IDirectXVideoMemoryConfiguration
    {
        public static readonly Guid Guid = new("b7f916dd-db3b-49c1-84d7-e45ef99ec726");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoMemoryConfiguration val)
            => Unsafe.As<IDirectXVideoMemoryConfiguration, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoMemoryConfiguration
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
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAvailableSurfaceTypeByIndex(uint dwTypeIndex, MIDLMIDLItfDxva2api000000060001* pdwType)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwType);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAvailableSurfaceTypeByIndex(uint dwTypeIndex, ref MIDLMIDLItfDxva2api000000060001 pdwType)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MIDLMIDLItfDxva2api000000060001* pdwTypePtr = &pdwType)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwTypePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwTypePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)LpVtbl[3])(@this, dwTypeIndex, pdwTypePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSurfaceType(MIDLMIDLItfDxva2api000000060001 dwType)
        {
            var @this = (IDirectXVideoMemoryConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirectXVideoMemoryConfiguration*, MIDLMIDLItfDxva2api000000060001, int>)LpVtbl[4])(@this, dwType);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, MIDLMIDLItfDxva2api000000060001, int>)LpVtbl[4])(@this, dwType);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoMemoryConfiguration*, MIDLMIDLItfDxva2api000000060001, int>)LpVtbl[4])(@this, dwType);
            }
            #endif
            return ret;
        }

    }
}
