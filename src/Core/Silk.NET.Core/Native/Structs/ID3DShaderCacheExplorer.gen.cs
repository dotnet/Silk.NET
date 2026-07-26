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

namespace Silk.NET.Core.Native
{
    [Guid("90432322-32f5-487f-9264-e9390fa58b2a")]
    [NativeName("Name", "ID3DShaderCacheExplorer")]
    public unsafe partial struct ID3DShaderCacheExplorer : IComVtbl<ID3DShaderCacheExplorer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("90432322-32f5-487f-9264-e9390fa58b2a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DShaderCacheExplorer val)
            => Unsafe.As<ID3DShaderCacheExplorer, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DShaderCacheExplorer
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
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Guid* riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riid, ppvApp);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, Guid* riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riid, ppvAppPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, ref Guid riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riidPtr, ppvApp);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, ref Guid riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePath, riidPtr, ppvAppPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, Guid* riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFullExePathPtr = &pFullExePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvApp);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, Guid* riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFullExePathPtr = &pFullExePath)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvAppPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, ref Guid riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFullExePathPtr = &pFullExePath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvApp);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, ref Guid riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFullExePathPtr = &pFullExePath)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvAppPtr = &ppvApp)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvAppPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Guid* riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvApp);
            SilkMarshal.Free((nint)pFullExePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, Guid* riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
            fixed (void** ppvAppPtr = &ppvApp)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riid, ppvAppPtr);
            }
            SilkMarshal.Free((nint)pFullExePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, ref Guid riid, void** ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvApp);
            }
            SilkMarshal.Free((nint)pFullExePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, ref Guid riid, ref void* ppvApp)
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFullExePathPtr = (byte*) SilkMarshal.StringToPtr(pFullExePath, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvAppPtr = &ppvApp)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheExplorer*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pFullExePathPtr, riidPtr, ppvAppPtr);
                }
            }
            SilkMarshal.Free((nint)pFullExePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvApp = default;
            return @this->GetApplicationFromExePath(pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvApp = default;
            return @this->GetApplicationFromExePath(in pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath, out ComPtr<TI0> ppvApp) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvApp = default;
            return @this->GetApplicationFromExePath(pFullExePath, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvApp.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(pFullExePath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(in pFullExePath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetApplicationFromExePath<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFullExePath) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheExplorer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetApplicationFromExePath(pFullExePath, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
