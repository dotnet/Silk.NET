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
    [Guid("c1ee4b59-3f59-47a5-9b4e-a855c858a878")]
    [NativeName("Name", "ID3D12CompilerFactory")]
    public unsafe partial struct ID3D12CompilerFactory : IComVtbl<ID3D12CompilerFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c1ee4b59-3f59-47a5-9b4e-a855c858a878");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12CompilerFactory val)
            => Unsafe.As<ID3D12CompilerFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12CompilerFactory
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
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateAdapterFamilies(uint AdapterFamilyIndex, AdapterFamily* pAdapterFamily)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, AdapterFamily*, int>)@this->LpVtbl[3])(@this, AdapterFamilyIndex, pAdapterFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateAdapterFamilies(uint AdapterFamilyIndex, ref AdapterFamily pAdapterFamily)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AdapterFamily* pAdapterFamilyPtr = &pAdapterFamily)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, AdapterFamily*, int>)@this->LpVtbl[3])(@this, AdapterFamilyIndex, pAdapterFamilyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, uint* pNumABIVersions, ulong* pABIVersions)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersions, pABIVersions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, uint* pNumABIVersions, ref ulong pABIVersions)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pABIVersionsPtr = &pABIVersions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersions, pABIVersionsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, ref uint pNumABIVersions, ulong* pABIVersions)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumABIVersionsPtr = &pNumABIVersions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersionsPtr, pABIVersions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateAdapterFamilyABIVersions(uint AdapterFamilyIndex, ref uint pNumABIVersions, ref ulong pABIVersions)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumABIVersionsPtr = &pNumABIVersions)
            {
                fixed (ulong* pABIVersionsPtr = &pABIVersions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, uint*, ulong*, int>)@this->LpVtbl[4])(@this, AdapterFamilyIndex, pNumABIVersionsPtr, pABIVersionsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnumerateAdapterFamilyCompilerVersion(uint AdapterFamilyIndex, VersionNumber* pCompilerVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, VersionNumber*, int>)@this->LpVtbl[5])(@this, AdapterFamilyIndex, pCompilerVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnumerateAdapterFamilyCompilerVersion(uint AdapterFamilyIndex, ref VersionNumber pCompilerVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionNumber* pCompilerVersionPtr = &pCompilerVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, uint, VersionNumber*, int>)@this->LpVtbl[5])(@this, AdapterFamilyIndex, pCompilerVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, VersionNumber* pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDesc, pApplicationProfileVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDesc, pApplicationProfileVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, VersionNumber* pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDescPtr, pApplicationProfileVersion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTarget, pApplicationDescPtr, pApplicationProfileVersionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, VersionNumber* pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDesc, pApplicationProfileVersion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDesc, pApplicationProfileVersionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, VersionNumber* pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDescPtr, pApplicationProfileVersion);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetApplicationProfileVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref VersionNumber pApplicationProfileVersion)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (VersionNumber* pApplicationProfileVersionPtr = &pApplicationProfileVersion)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerTarget*, ApplicationDesc*, VersionNumber*, int>)@this->LpVtbl[6])(@this, pTargetPtr, pApplicationDescPtr, pApplicationProfileVersionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerTarget* pTargetPtr = &pTarget)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPaths, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTarget, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSession);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riid, ppCompilerCacheSessionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDesc, riidPtr, ppCompilerCacheSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSession);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                    {
                        fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riid, ppCompilerCacheSessionPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSession);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerDatabasePath* pPathsPtr = &pPaths)
            {
                fixed (CompilerTarget* pTargetPtr = &pTarget)
                {
                    fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, CompilerDatabasePath*, uint, CompilerTarget*, ApplicationDesc*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pPathsPtr, NumPaths, pTargetPtr, pApplicationDescPtr, riidPtr, ppCompilerCacheSessionPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, Guid* riid, void** ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riid, ppCompiler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, Guid* riid, ref void* ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerPtr = &ppCompiler)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riid, ppCompilerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, ref Guid riid, void** ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riidPtr, ppCompiler);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ID3D12CompilerCacheSession* pCompilerCacheSession, ref Guid riid, ref void* ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerPtr = &ppCompiler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSession, riidPtr, ppCompilerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ref ID3D12CompilerCacheSession pCompilerCacheSession, Guid* riid, void** ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riid, ppCompiler);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ref ID3D12CompilerCacheSession pCompilerCacheSession, Guid* riid, ref void* ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
            {
                fixed (void** ppCompilerPtr = &ppCompiler)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riid, ppCompilerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ref ID3D12CompilerCacheSession pCompilerCacheSession, ref Guid riid, void** ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riidPtr, ppCompiler);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler(ref ID3D12CompilerCacheSession pCompilerCacheSession, ref Guid riid, ref void* ppCompiler)
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerCacheSession* pCompilerCacheSessionPtr = &pCompilerCacheSession)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerPtr = &ppCompiler)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerFactory*, ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pCompilerCacheSessionPtr, riidPtr, ppCompilerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc, out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, in pApplicationDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompiler<TI0, TI1>(ComPtr<TI0> pCompilerCacheSession, out ComPtr<TI1> ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompiler = default;
            return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppCompiler.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler<TI0>(ComPtr<TI0> pCompilerCacheSession, Guid* riid, ref void* ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, riid, ref ppCompiler);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler<TI0>(ComPtr<TI0> pCompilerCacheSession, ref Guid riid, void** ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, ref riid, ppCompiler);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompiler<TI0>(ComPtr<TI0> pCompilerCacheSession, ref Guid riid, ref void* ppCompiler) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCompiler((ID3D12CompilerCacheSession*) pCompilerCacheSession.Handle, ref riid, ref ppCompiler);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCompiler<TI0>(ref ID3D12CompilerCacheSession pCompilerCacheSession, out ComPtr<TI0> ppCompiler) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompiler = default;
            return @this->CreateCompiler(ref pCompilerCacheSession, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompiler.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerDatabasePath* pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(pPaths, NumPaths, in pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerTarget* pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCompilerCacheSession<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerDatabasePath pPaths, uint NumPaths, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerTarget pTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompilerCacheSession(in pPaths, NumPaths, in pTarget, in pApplicationDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateCompiler<TI0, TI1>(ComPtr<TI0> pCompilerCacheSession) where TI0 : unmanaged, IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompiler(pCompilerCacheSession, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateCompiler<TI0>(ref ID3D12CompilerCacheSession pCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateCompiler(ref pCompilerCacheSession, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
