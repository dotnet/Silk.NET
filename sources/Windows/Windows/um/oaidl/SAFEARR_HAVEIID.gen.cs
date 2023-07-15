// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SAFEARR_HAVEIID.xml' path='doc/member[@name="SAFEARR_HAVEIID"]/*'/>
public unsafe partial struct SAFEARR_HAVEIID
{
    /// <include file='SAFEARR_HAVEIID.xml' path='doc/member[@name="SAFEARR_HAVEIID.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='SAFEARR_HAVEIID.xml' path='doc/member[@name="SAFEARR_HAVEIID.apUnknown"]/*'/>
    public IUnknown** apUnknown;
    /// <include file='SAFEARR_HAVEIID.xml' path='doc/member[@name="SAFEARR_HAVEIID.iid"]/*'/>
    [NativeTypeName("IID")]
    public Guid iid;
}