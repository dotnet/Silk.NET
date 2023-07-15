// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='userSTGMEDIUM.xml' path='doc/member[@name="userSTGMEDIUM"]/*'/>
public unsafe partial struct userSTGMEDIUM
{
    /// <include file='userSTGMEDIUM.xml' path='doc/member[@name="userSTGMEDIUM.pUnkForRelease"]/*'/>
    public IUnknown* pUnkForRelease;
    /// <include file='_STGMEDIUM_UNION.xml' path='doc/member[@name="_STGMEDIUM_UNION"]/*'/>
    public partial struct _STGMEDIUM_UNION
    {
        /// <include file='_STGMEDIUM_UNION.xml' path='doc/member[@name="_STGMEDIUM_UNION.tymed"]/*'/>
        [NativeTypeName("DWORD")]
        public uint tymed;
        /// <include file='_STGMEDIUM_UNION.xml' path='doc/member[@name="_STGMEDIUM_UNION.u"]/*'/>
        [NativeTypeName("union __MIDL_IAdviseSink_0003")]
        public _u_e__Union u;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_e__Union
        {
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hMetaFilePict"]/*'/>
            [FieldOffset(0)]
            [NativeTypeName("wireHMETAFILEPICT")]
            public userHMETAFILEPICT* hMetaFilePict;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hHEnhMetaFile"]/*'/>
            [FieldOffset(0)]
            [NativeTypeName("wireHENHMETAFILE")]
            public userHENHMETAFILE* hHEnhMetaFile;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hGdiHandle"]/*'/>
            [FieldOffset(0)]
            public GDI_OBJECT* hGdiHandle;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hGlobal"]/*'/>
            [FieldOffset(0)]
            [NativeTypeName("wireHGLOBAL")]
            public userHGLOBAL* hGlobal;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.lpszFileName"]/*'/>
            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public ushort* lpszFileName;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.pstm"]/*'/>
            [FieldOffset(0)]
            public BYTE_BLOB* pstm;
            /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.pstg"]/*'/>
            [FieldOffset(0)]
            public BYTE_BLOB* pstg;
        }
    }
}