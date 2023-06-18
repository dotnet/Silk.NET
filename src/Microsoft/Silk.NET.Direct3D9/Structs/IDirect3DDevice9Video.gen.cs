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
    [Guid("26dc4561-a1ee-4ae7-96da-118a36c0ec95")]
    [NativeName("Name", "IDirect3DDevice9Video")]
    public unsafe partial struct IDirect3DDevice9Video : IComVtbl<IDirect3DDevice9Video>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("26dc4561-a1ee-4ae7-96da-118a36c0ec95");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DDevice9Video val)
            => Unsafe.As<IDirect3DDevice9Video, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DDevice9Video
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
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContentProtectionCaps([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, Contentprotectioncaps* pCaps)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, Contentprotectioncaps*, int>)@this->LpVtbl[3])(@this, pCryptoType, pDecodeProfile, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateAuthenticatedChannel(Authenticatedchanneltype ChannelType, IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, void** pChannelHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Authenticatedchanneltype, IDirect3DAuthenticatedChannel9**, void**, int>)@this->LpVtbl[4])(@this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCryptoSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pCryptoType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pDecodeProfile, IDirect3DCryptoSession9** ppCryptoSession, void** pCryptoHandle)
        {
            var @this = (IDirect3DDevice9Video*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, void**, int>)@this->LpVtbl[5])(@this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
            return ret;
        }

    }
}
