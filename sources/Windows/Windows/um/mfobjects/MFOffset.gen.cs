// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFOffset.xml' path='doc/member[@name="MFOffset"]/*'/>
public partial struct MFOffset
{
    /// <include file='MFOffset.xml' path='doc/member[@name="MFOffset.fract"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fract;
    /// <include file='MFOffset.xml' path='doc/member[@name="MFOffset.value"]/*'/>
    public short value;
}