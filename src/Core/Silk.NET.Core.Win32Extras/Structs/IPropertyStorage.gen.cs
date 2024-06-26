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
    [Guid("00000138-0000-0000-c000-000000000046")]
    [NativeName("Name", "IPropertyStorage")]
    public unsafe partial struct IPropertyStorage : IComVtbl<IPropertyStorage>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000138-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPropertyStorage val)
            => Unsafe.As<IPropertyStorage, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPropertyStorage
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
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadMultiple(uint cpspec, PropSpec* rgpspec, PropVariant* rgpropvar)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspec, rgpropvar);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadMultiple(uint cpspec, PropSpec* rgpspec, ref PropVariant rgpropvar)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropVariant* rgpropvarPtr = &rgpropvar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspec, rgpropvarPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadMultiple(uint cpspec, ref PropSpec rgpspec, PropVariant* rgpropvar)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropSpec* rgpspecPtr = &rgpspec)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspecPtr, rgpropvar);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReadMultiple(uint cpspec, ref PropSpec rgpspec, ref PropVariant rgpropvar)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropSpec* rgpspecPtr = &rgpspec)
            {
                fixed (PropVariant* rgpropvarPtr = &rgpropvar)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, int>)@this->LpVtbl[3])(@this, cpspec, rgpspecPtr, rgpropvarPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteMultiple(uint cpspec, PropSpec* rgpspec, PropVariant* rgpropvar, uint propidNameFirst)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspec, rgpropvar, propidNameFirst);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteMultiple(uint cpspec, PropSpec* rgpspec, ref PropVariant rgpropvar, uint propidNameFirst)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropVariant* rgpropvarPtr = &rgpropvar)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspec, rgpropvarPtr, propidNameFirst);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteMultiple(uint cpspec, ref PropSpec rgpspec, PropVariant* rgpropvar, uint propidNameFirst)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropSpec* rgpspecPtr = &rgpspec)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspecPtr, rgpropvar, propidNameFirst);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteMultiple(uint cpspec, ref PropSpec rgpspec, ref PropVariant rgpropvar, uint propidNameFirst)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropSpec* rgpspecPtr = &rgpspec)
            {
                fixed (PropVariant* rgpropvarPtr = &rgpropvar)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, PropVariant*, uint, int>)@this->LpVtbl[4])(@this, cpspec, rgpspecPtr, rgpropvarPtr, propidNameFirst);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DeleteMultiple(uint cpspec, PropSpec* rgpspec)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, int>)@this->LpVtbl[5])(@this, cpspec, rgpspec);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeleteMultiple(uint cpspec, ref PropSpec rgpspec)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PropSpec* rgpspecPtr = &rgpspec)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, PropSpec*, int>)@this->LpVtbl[5])(@this, cpspec, rgpspecPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadPropertyNames(uint cpropid, uint* rgpropid, char** rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropid, rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadPropertyNames(uint cpropid, uint* rgpropid, ref char* rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rglpwstrNamePtr = &rglpwstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropid, rglpwstrNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadPropertyNames(uint cpropid, ref uint rgpropid, char** rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rgpropidPtr = &rgpropid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropidPtr, rglpwstrName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadPropertyNames(uint cpropid, ref uint rgpropid, ref char* rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rgpropidPtr = &rgpropid)
            {
                fixed (char** rglpwstrNamePtr = &rglpwstrName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, cpropid, rgpropidPtr, rglpwstrNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePropertyNames(uint cpropid, uint* rgpropid, char** rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropid, rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePropertyNames(uint cpropid, uint* rgpropid, ref char* rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rglpwstrNamePtr = &rglpwstrName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropid, rglpwstrNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePropertyNames(uint cpropid, ref uint rgpropid, char** rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rgpropidPtr = &rgpropid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropidPtr, rglpwstrName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePropertyNames(uint cpropid, ref uint rgpropid, ref char* rglpwstrName)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rgpropidPtr = &rgpropid)
            {
                fixed (char** rglpwstrNamePtr = &rglpwstrName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, char**, int>)@this->LpVtbl[7])(@this, cpropid, rgpropidPtr, rglpwstrNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DeletePropertyNames(uint cpropid, uint* rgpropid)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, int>)@this->LpVtbl[8])(@this, cpropid, rgpropid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DeletePropertyNames(uint cpropid, ref uint rgpropid)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rgpropidPtr = &rgpropid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, uint*, int>)@this->LpVtbl[8])(@this, cpropid, rgpropidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Commit(uint grfCommitFlags)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, uint, int>)@this->LpVtbl[9])(@this, grfCommitFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Revert()
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, int>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(IEnumSTATPROPSTG** ppenum)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, IEnumSTATPROPSTG**, int>)@this->LpVtbl[11])(@this, ppenum);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Enum(ref IEnumSTATPROPSTG* ppenum)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IEnumSTATPROPSTG** ppenumPtr = &ppenum)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, IEnumSTATPROPSTG**, int>)@this->LpVtbl[11])(@this, ppenumPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patime, pmtime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pmtimePtr = &pmtime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patime, pmtimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* patimePtr = &patime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patimePtr, pmtime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* patimePtr = &patime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctime, patimePtr, pmtimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pctimePtr = &pctime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patime, pmtime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* pmtimePtr = &pmtime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patime, pmtimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Filetime* pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* patimePtr = &patime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patimePtr, pmtime);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTimes([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pctime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime patime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Filetime pmtime)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Filetime* pctimePtr = &pctime)
            {
                fixed (Filetime* patimePtr = &patime)
                {
                    fixed (Filetime* pmtimePtr = &pmtime)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Filetime*, Filetime*, Filetime*, int>)@this->LpVtbl[12])(@this, pctimePtr, patimePtr, pmtimePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetClass(Guid* clsid)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, int>)@this->LpVtbl[13])(@this, clsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetClass(ref Guid clsid)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, Guid*, int>)@this->LpVtbl[13])(@this, clsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Stat(STATPROPSETSTG* pstatpsstg)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, STATPROPSETSTG*, int>)@this->LpVtbl[14])(@this, pstatpsstg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Stat(ref STATPROPSETSTG pstatpsstg)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (STATPROPSETSTG* pstatpsstgPtr = &pstatpsstg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyStorage*, STATPROPSETSTG*, int>)@this->LpVtbl[14])(@this, pstatpsstgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadPropertyNames(uint cpropid, uint* rgpropid, string[] rglpwstrNameSa)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
            var ret = @this->ReadPropertyNames(cpropid, rgpropid, rglpwstrName);
            SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
            SilkMarshal.Free((nint) rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReadPropertyNames(uint cpropid, ref uint rgpropid, string[] rglpwstrNameSa)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
            var ret = @this->ReadPropertyNames(cpropid, ref rgpropid, rglpwstrName);
            SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
            SilkMarshal.Free((nint) rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WritePropertyNames(uint cpropid, uint* rgpropid, string[] rglpwstrNameSa)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
            var ret = @this->WritePropertyNames(cpropid, rgpropid, rglpwstrName);
            SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
            SilkMarshal.Free((nint) rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WritePropertyNames(uint cpropid, ref uint rgpropid, string[] rglpwstrNameSa)
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rglpwstrName = (char**) SilkMarshal.StringArrayToPtr(rglpwstrNameSa);
            var ret = @this->WritePropertyNames(cpropid, ref rgpropid, rglpwstrName);
            SilkMarshal.CopyPtrToStringArray((nint) rglpwstrName, rglpwstrNameSa);
            SilkMarshal.Free((nint) rglpwstrName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Enum<TI0>(ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumSTATPROPSTG>, IComVtbl<TI0>
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Enum((IEnumSTATPROPSTG**) ppenum.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPropertyStorage*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
