// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLEMENUGROUPWIDTHS.xml' path='doc/member[@name="OLEMENUGROUPWIDTHS"]/*'/>
public unsafe partial struct OLEMENUGROUPWIDTHS
{
    /// <include file='OLEMENUGROUPWIDTHS.xml' path='doc/member[@name="OLEMENUGROUPWIDTHS.width"]/*'/>
    [NativeTypeName("LONG[6]")]
    public fixed int width[6];
}