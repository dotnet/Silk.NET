// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SAFEARRAYBOUND.xml' path='doc/member[@name="SAFEARRAYBOUND"]/*'/>
public partial struct SAFEARRAYBOUND
{
    /// <include file='SAFEARRAYBOUND.xml' path='doc/member[@name="SAFEARRAYBOUND.cElements"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cElements;
    /// <include file='SAFEARRAYBOUND.xml' path='doc/member[@name="SAFEARRAYBOUND.lLbound"]/*'/>
    [NativeTypeName("LONG")]
    public int lLbound;
}