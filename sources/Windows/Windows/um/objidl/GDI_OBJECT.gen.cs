// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='GDI_OBJECT.xml' path='doc/member[@name="GDI_OBJECT"]/*' />
public partial struct GDI_OBJECT
{
    /// <include file='GDI_OBJECT.xml' path='doc/member[@name="GDI_OBJECT.ObjectType"]/*' />
    [NativeTypeName("DWORD")]
    public uint ObjectType;

    /// <include file='GDI_OBJECT.xml' path='doc/member[@name="GDI_OBJECT.u"]/*' />
    [NativeTypeName("union __MIDL_IAdviseSink_0002")]
    public _u_e__Union u;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hBitmap"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("wireHBITMAP")]
        public userHBITMAP* hBitmap;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hPalette"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("wireHPALETTE")]
        public userHPALETTE* hPalette;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hGeneric"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("wireHGLOBAL")]
        public userHGLOBAL* hGeneric;
    }
}
