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
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    [NativeName("Name", "__AnonymousRecord_objidl_L12046_C36")]
    public unsafe partial struct STGMEDIUMUnion
    {
        public STGMEDIUMUnion
        (
            void* hBitmap = null,
            void* hMetaFilePict = null,
            nint* hEnhMetaFile = null,
            void* hGlobal = null,
            char* lpszFileName = null,
            Silk.NET.Core.Win32Extras.IStream* pstm = null,
            IStorage* pstg = null
        ) : this()
        {
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


        [FieldOffset(0)]
        [NativeName("Type", "HBITMAP")]
        [NativeName("Type.Name", "HBITMAP")]
        [NativeName("Name", "hBitmap")]
        public void* HBitmap;

        [FieldOffset(0)]
        [NativeName("Type", "HMETAFILEPICT")]
        [NativeName("Type.Name", "HMETAFILEPICT")]
        [NativeName("Name", "hMetaFilePict")]
        public void* HMetaFilePict;

        [FieldOffset(0)]
        [NativeName("Type", "HENHMETAFILE")]
        [NativeName("Type.Name", "HENHMETAFILE")]
        [NativeName("Name", "hEnhMetaFile")]
        public nint* HEnhMetaFile;

        [FieldOffset(0)]
        [NativeName("Type", "HGLOBAL")]
        [NativeName("Type.Name", "HGLOBAL")]
        [NativeName("Name", "hGlobal")]
        public void* HGlobal;

        [FieldOffset(0)]
        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "lpszFileName")]
        public char* LpszFileName;

        [FieldOffset(0)]
        [NativeName("Type", "IStream *")]
        [NativeName("Type.Name", "IStream *")]
        [NativeName("Name", "pstm")]
        public Silk.NET.Core.Win32Extras.IStream* Pstm;

        [FieldOffset(0)]
        [NativeName("Type", "IStorage *")]
        [NativeName("Type.Name", "IStorage *")]
        [NativeName("Name", "pstg")]
        public IStorage* Pstg;
    }
}
