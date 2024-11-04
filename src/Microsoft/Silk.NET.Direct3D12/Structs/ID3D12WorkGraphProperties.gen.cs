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
    [Guid("065acf71-f863-4b89-82f4-02e4d5886757")]
    [NativeName("Name", "ID3D12WorkGraphProperties")]
    public unsafe partial struct ID3D12WorkGraphProperties : IComVtbl<ID3D12WorkGraphProperties>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("065acf71-f863-4b89-82f4-02e4d5886757");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12WorkGraphProperties val)
            => Unsafe.As<ID3D12WorkGraphProperties, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12WorkGraphProperties
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
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumWorkGraphs()
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe char* GetProgramName(uint WorkGraphIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            char* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, char*>)@this->LpVtbl[4])(@this, WorkGraphIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)]
        public readonly string GetProgramNameS(uint WorkGraphIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, string>)@this->LpVtbl[4])(@this, WorkGraphIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetWorkGraphIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, char*, uint>)@this->LpVtbl[5])(@this, pProgramName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetWorkGraphIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pProgramName)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, char*, uint>)@this->LpVtbl[5])(@this, pProgramNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetWorkGraphIndex([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, byte*, uint>)@this->LpVtbl[5])(@this, pProgramNamePtr);
            SilkMarshal.Free((nint)pProgramNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumNodes(uint WorkGraphIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint>)@this->LpVtbl[6])(@this, WorkGraphIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly NodeID GetNodeID(uint WorkGraphIndex, uint NodeIndex)
        {
            NodeID silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            NodeID* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, NodeID*, uint, uint, NodeID*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, WorkGraphIndex, NodeIndex);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeIndex(uint WorkGraphIndex, NodeID NodeID)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, NodeID, uint>)@this->LpVtbl[8])(@this, WorkGraphIndex, NodeID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint, uint>)@this->LpVtbl[9])(@this, WorkGraphIndex, NodeIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumEntrypoints(uint WorkGraphIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint>)@this->LpVtbl[10])(@this, WorkGraphIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly NodeID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex)
        {
            NodeID silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            NodeID* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, NodeID*, uint, uint, NodeID*>)@this->LpVtbl[11])(@this, pSilkDotNetReturnFixupResult, WorkGraphIndex, EntrypointIndex);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetEntrypointIndex(uint WorkGraphIndex, NodeID NodeID)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, NodeID, uint>)@this->LpVtbl[12])(@this, WorkGraphIndex, NodeID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, uint, uint>)@this->LpVtbl[13])(@this, WorkGraphIndex, EntrypointIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, WorkGraphMemoryRequirements* pWorkGraphMemoryRequirements)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, WorkGraphMemoryRequirements*, void>)@this->LpVtbl[14])(@this, WorkGraphIndex, pWorkGraphMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetWorkGraphMemoryRequirements(uint WorkGraphIndex, ref WorkGraphMemoryRequirements pWorkGraphMemoryRequirements)
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WorkGraphMemoryRequirements* pWorkGraphMemoryRequirementsPtr = &pWorkGraphMemoryRequirements)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12WorkGraphProperties*, uint, WorkGraphMemoryRequirements*, void>)@this->LpVtbl[14])(@this, WorkGraphIndex, pWorkGraphMemoryRequirementsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12WorkGraphProperties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
