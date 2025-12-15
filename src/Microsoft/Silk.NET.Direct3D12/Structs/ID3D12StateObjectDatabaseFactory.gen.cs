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

namespace Silk.NET.Direct3D12
{
    [Guid("f5b066f0-648a-4611-bd41-27fd0948b9eb")]
    [NativeName("Name", "ID3D12StateObjectDatabaseFactory")]
    public unsafe partial struct ID3D12StateObjectDatabaseFactory : IComVtbl<ID3D12StateObjectDatabaseFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f5b066f0-648a-4611-bd41-27fd0948b9eb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12StateObjectDatabaseFactory val)
            => Unsafe.As<ID3D12StateObjectDatabaseFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12StateObjectDatabaseFactory
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
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riid, ppvStateObjectDatabase);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riid, ppvStateObjectDatabasePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riidPtr, ppvStateObjectDatabase);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFile, flags, riidPtr, ppvStateObjectDatabasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pDatabaseFilePtr = &pDatabaseFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabase);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pDatabaseFilePtr = &pDatabaseFile)
            {
                fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabasePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pDatabaseFilePtr = &pDatabaseFile)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabase);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pDatabaseFilePtr = &pDatabaseFile)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, char*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabasePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabase);
            SilkMarshal.Free((nint)pDatabaseFilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, Guid* riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
            fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riid, ppvStateObjectDatabasePtr);
            }
            SilkMarshal.Free((nint)pDatabaseFilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, void** ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabase);
            }
            SilkMarshal.Free((nint)pDatabaseFilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, ref Guid riid, ref void* ppvStateObjectDatabase)
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDatabaseFilePtr = (byte*) SilkMarshal.StringToPtr(pDatabaseFile, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvStateObjectDatabasePtr = &ppvStateObjectDatabase)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabaseFactory*, byte*, StateObjectDatabaseFlags, Guid*, void**, int>)@this->LpVtbl[3])(@this, pDatabaseFilePtr, flags, riidPtr, ppvStateObjectDatabasePtr);
                }
            }
            SilkMarshal.Free((nint)pDatabaseFilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvStateObjectDatabase = default;
            return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvStateObjectDatabase = default;
            return @this->CreateStateObjectDatabaseFromFile(in pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags, out ComPtr<TI0> ppvStateObjectDatabase) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvStateObjectDatabase = default;
            return @this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvStateObjectDatabase.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(in pDatabaseFile, flags, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateStateObjectDatabaseFromFile<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pDatabaseFile, StateObjectDatabaseFlags flags) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabaseFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateStateObjectDatabaseFromFile(pDatabaseFile, flags, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
