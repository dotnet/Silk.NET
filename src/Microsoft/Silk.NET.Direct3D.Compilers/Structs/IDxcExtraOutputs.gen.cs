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
    [Guid("319b37a2-a5c2-494a-a5de-4801b2faf989")]
    [NativeName("Name", "IDxcExtraOutputs")]
    public unsafe partial struct IDxcExtraOutputs
    {
        public static readonly Guid Guid = new("319b37a2-a5c2-494a-a5de-4801b2faf989");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcExtraOutputs val)
            => Unsafe.As<IDxcExtraOutputs, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcExtraOutputs
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
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetOutputCount()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                {
                    fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobUtf16** ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, IDxcBlobUtf16** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobUtf16* ppOutputType, ref IDxcBlobUtf16* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobUtf16** ppOutputTypePtr = &ppOutputType)
                    {
                        fixed (IDxcBlobUtf16** ppOutputNamePtr = &ppOutputName)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobUtf16**, IDxcBlobUtf16**, int>)LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                        }
                    }
                }
            }
            return ret;
        }

    }
}
