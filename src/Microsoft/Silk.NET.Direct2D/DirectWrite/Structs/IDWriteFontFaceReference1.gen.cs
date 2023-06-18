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

namespace Silk.NET.DirectWrite
{
    [Guid("c081fe77-2fd1-41ac-a5a3-34983c4ba61a")]
    [NativeName("Name", "IDWriteFontFaceReference1")]
    public unsafe partial struct IDWriteFontFaceReference1 : IComVtbl<IDWriteFontFaceReference1>, IComVtbl<IDWriteFontFaceReference>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c081fe77-2fd1-41ac-a5a3-34983c4ba61a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFaceReference(IDWriteFontFaceReference1 val)
            => Unsafe.As<IDWriteFontFaceReference1, IDWriteFontFaceReference>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFaceReference1 val)
            => Unsafe.As<IDWriteFontFaceReference1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFaceReference1
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
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(IDWriteFontFace3** fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)@this->LpVtbl[3])(@this, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceWithSimulations(FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)@this->LpVtbl[4])(@this, fontFaceSimulationFlags, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe Silk.NET.Core.Bool32 Equals(IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFaceIndex()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontSimulations GetSimulations()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontSimulations ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFile(IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetLocalFileSize()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetFileSize()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileTime(Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[11])(@this, lastWriteTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetLocality()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Locality>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueFontDownloadRequest()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, int>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueCharacterDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, char*, uint, int>)@this->LpVtbl[14])(@this, characters, characterCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueGlyphDownloadRequest([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)@this->LpVtbl[15])(@this, glyphIndices, glyphCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueFileFragmentDownloadRequest(ulong fileOffset, ulong fragmentSize)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong, ulong, int>)@this->LpVtbl[16])(@this, fileOffset, fragmentSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontAxisValueCount()
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteFontFaceReference1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)@this->LpVtbl[19])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

    }
}
