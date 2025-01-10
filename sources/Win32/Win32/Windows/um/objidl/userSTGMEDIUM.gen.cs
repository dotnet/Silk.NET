// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct userSTGMEDIUM
{
    public IUnknown pUnkForRelease;

    public partial struct _STGMEDIUM_UNION
    {
        [NativeTypeName("DWORD")]
        public uint tymed;

        [NativeTypeName("union __MIDL_IAdviseSink_0003")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("wireHMETAFILEPICT")]
            public userHMETAFILEPICT* hMetaFilePict;

            [FieldOffset(0)]
            [NativeTypeName("wireHENHMETAFILE")]
            public userHENHMETAFILE* hHEnhMetaFile;

            [FieldOffset(0)]
            public GDI_OBJECT* hGdiHandle;

            [FieldOffset(0)]
            [NativeTypeName("wireHGLOBAL")]
            public userHGLOBAL* hGlobal;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public ushort* lpszFileName;

            [FieldOffset(0)]
            public BYTE_BLOB* pstm;

            [FieldOffset(0)]
            public BYTE_BLOB* pstg;
        }
    }
}
