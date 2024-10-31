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
    public unsafe partial struct IDxcExtraOutputs : IComVtbl<IDxcExtraOutputs>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("319b37a2-a5c2-494a-a5de-4801b2faf989");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetOutputCount()
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobWide** ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, IDxcBlobWide** ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputType, ppOutputNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobWide* ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, void** ppvObject, ref IDxcBlobWide* ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
            {
                fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobWide** ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, IDxcBlobWide** ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                {
                    fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iid, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobWide** ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, IDxcBlobWide** ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputType, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobWide* ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobWide* ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                {
                    fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObject, ppOutputTypePtr, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobWide** ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, IDxcBlobWide** ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputType, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputName);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobWide** ppOutputTypePtr = &ppOutputType)
                    {
                        fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcExtraOutputs*, uint, Guid*, void**, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[4])(@this, uIndex, iidPtr, ppvObjectPtr, ppOutputTypePtr, ppOutputNamePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOutput<TI0, TI1, TI2>(uint uIndex, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputType, ref ComPtr<TI2> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI2>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobWide**) ppOutputType.GetAddressOf(), (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0, TI1>(uint uIndex, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputType, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobWide**) ppOutputType.GetAddressOf(), ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0, TI1>(uint uIndex, ref ComPtr<TI0> ppvObject, ref IDxcBlobWide* ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputType, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, ref ComPtr<TI0> ppvObject, ref IDxcBlobWide* ppOutputType, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputType, ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0, TI1>(uint uIndex, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, iid, ref ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, iid, ref ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, Guid* iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, iid, ref ppvObject, ref ppOutputType, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0, TI1>(uint uIndex, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, ref Guid iid, void** ppvObject, ref IDxcBlobWide* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ppvObject, ref ppOutputType, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0, TI1>(uint uIndex, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ref ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputType, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ref ppvObject, (IDxcBlobWide**) ppOutputType.GetAddressOf(), ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(uint uIndex, ref Guid iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputType, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(uIndex, ref iid, ref ppvObject, ref ppOutputType, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcExtraOutputs*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
