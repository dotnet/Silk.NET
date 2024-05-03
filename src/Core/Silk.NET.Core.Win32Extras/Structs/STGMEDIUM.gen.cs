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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagSTGMEDIUM")]
    public unsafe partial struct STGMEDIUM
    {
        public STGMEDIUM
        (
            uint? tymed = null,
            STGMEDIUMUnion? anonymous = null,
            Silk.NET.Core.Native.IUnknown* pUnkForRelease = null,
            void* hBitmap = null,
            void* hMetaFilePict = null,
            nint* hEnhMetaFile = null,
            void* hGlobal = null,
            char* lpszFileName = null,
            Silk.NET.Core.Win32Extras.IStream* pstm = null,
            IStorage* pstg = null
        ) : this()
        {
            if (tymed is not null)
            {
                Tymed = tymed.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pUnkForRelease is not null)
            {
                PUnkForRelease = pUnkForRelease;
            }

            if (hBitmap is not null)
            {
                HBitmap = hBitmap;
            }

            if (hMetaFilePict is not null)
            {
                HMetaFilePict = hMetaFilePict;
            }

            if (hEnhMetaFile is not null)
            {
                HEnhMetaFile = hEnhMetaFile;
            }

            if (hGlobal is not null)
            {
                HGlobal = hGlobal;
            }

            if (lpszFileName is not null)
            {
                LpszFileName = lpszFileName;
            }

            if (pstm is not null)
            {
                Pstm = pstm;
            }

            if (pstg is not null)
            {
                Pstg = pstg;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "tymed")]
        public uint Tymed;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_objidl_L12046_C36")]
        [NativeName("Name", "anonymous1")]
        public STGMEDIUMUnion Anonymous;

        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pUnkForRelease")]
        public Silk.NET.Core.Native.IUnknown* PUnkForRelease;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* HBitmap
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HBitmap;
        }
#else
        public void* HBitmap
        {
            get => Anonymous.HBitmap;
            set => Anonymous.HBitmap = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* HMetaFilePict
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HMetaFilePict;
        }
#else
        public void* HMetaFilePict
        {
            get => Anonymous.HMetaFilePict;
            set => Anonymous.HMetaFilePict = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref nint* HEnhMetaFile
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HEnhMetaFile;
        }
#else
        public nint* HEnhMetaFile
        {
            get => Anonymous.HEnhMetaFile;
            set => Anonymous.HEnhMetaFile = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* HGlobal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HGlobal;
        }
#else
        public void* HGlobal
        {
            get => Anonymous.HGlobal;
            set => Anonymous.HGlobal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref char* LpszFileName
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].LpszFileName;
        }
#else
        public char* LpszFileName
        {
            get => Anonymous.LpszFileName;
            set => Anonymous.LpszFileName = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Win32Extras.IStream* Pstm
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pstm;
        }
#else
        public Silk.NET.Core.Win32Extras.IStream* Pstm
        {
            get => Anonymous.Pstm;
            set => Anonymous.Pstm = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IStorage* Pstg
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pstg;
        }
#else
        public IStorage* Pstg
        {
            get => Anonymous.Pstg;
            set => Anonymous.Pstg = value;
        }
#endif

    }
}
