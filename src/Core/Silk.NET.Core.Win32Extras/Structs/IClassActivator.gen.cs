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
    [Guid("00000140-0000-0000-c000-000000000046")]
    [NativeName("Name", "IClassActivator")]
    public unsafe partial struct IClassActivator : IComVtbl<IClassActivator>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000140-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IClassActivator val)
            => Unsafe.As<IClassActivator, Silk.NET.Core.Native.IUnknown>(ref val);

        public IClassActivator
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
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(Guid* rclsid, uint dwClassContext, uint locale, Guid* riid, void** ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(Guid* rclsid, uint dwClassContext, uint locale, Guid* riid, ref void* ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(Guid* rclsid, uint dwClassContext, uint locale, ref Guid riid, void** ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(Guid* rclsid, uint dwClassContext, uint locale, ref Guid riid, ref void* ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsid, dwClassContext, locale, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(ref Guid rclsid, uint dwClassContext, uint locale, Guid* riid, void** ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(ref Guid rclsid, uint dwClassContext, uint locale, Guid* riid, ref void* ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(ref Guid rclsid, uint dwClassContext, uint locale, ref Guid riid, void** ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject(ref Guid rclsid, uint dwClassContext, uint locale, ref Guid riid, ref void* ppv)
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rclsidPtr = &rclsid)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)@this->LpVtbl[3])(@this, rclsidPtr, dwClassContext, locale, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClassObject<TI0>(Guid* rclsid, uint dwClassContext, uint locale, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetClassObject(rclsid, dwClassContext, locale, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClassObject<TI0>(ref Guid rclsid, uint dwClassContext, uint locale, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetClassObject(ref rclsid, dwClassContext, locale, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetClassObject<TI0>(Guid* rclsid, uint dwClassContext, uint locale) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetClassObject(rclsid, dwClassContext, locale, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetClassObject<TI0>(ref Guid rclsid, uint dwClassContext, uint locale) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IClassActivator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetClassObject(ref rclsid, dwClassContext, locale, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
