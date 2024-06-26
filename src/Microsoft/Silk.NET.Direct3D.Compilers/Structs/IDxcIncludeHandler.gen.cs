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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("7f61fc7d-950d-467f-b3e3-3c02fb49187c")]
    [NativeName("Name", "IDxcIncludeHandler")]
    public unsafe partial struct IDxcIncludeHandler : IComVtbl<IDxcIncludeHandler>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7f61fc7d-950d-467f-b3e3-3c02fb49187c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcIncludeHandler val)
            => Unsafe.As<IDxcIncludeHandler, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcIncludeHandler
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
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFilenamePtr = &pFilename)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFilenamePtr = &pFilename)
            {
                fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, char*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, IDxcBlob** ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            SilkMarshal.Free((nint)pFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref IDxcBlob* ppIncludeSource)
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFilenamePtr = (byte*) SilkMarshal.StringToPtr(pFilename, NativeStringEncoding.LPWStr);
            fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
            }
            SilkMarshal.Free((nint)pFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadSource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadSource(pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadSource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadSource(in pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int LoadSource<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFilename, ref ComPtr<TI0> ppIncludeSource) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->LoadSource(pFilename, (IDxcBlob**) ppIncludeSource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcIncludeHandler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
