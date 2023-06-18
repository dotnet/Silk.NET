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
    [Guid("f1df64b6-57fd-49cd-8807-c0eb88b45c8f")]
    [NativeName("Name", "ID3D12SwapChainAssistant")]
    public unsafe partial struct ID3D12SwapChainAssistant : IComVtbl<ID3D12SwapChainAssistant>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f1df64b6-57fd-49cd-8807-c0eb88b45c8f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12SwapChainAssistant val)
            => Unsafe.As<ID3D12SwapChainAssistant, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12SwapChainAssistant
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
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Luid GetLUID()
        {
            Luid silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Luid* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid*, Luid*>)@this->LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSwapChainObject(Guid* riid, void** ppv)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentResourceAndCommandQueue(Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InsertImplicitSync()
        {
            var @this = (ID3D12SwapChainAssistant*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

    }
}
