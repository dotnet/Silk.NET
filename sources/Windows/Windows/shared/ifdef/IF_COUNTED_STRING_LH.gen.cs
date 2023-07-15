// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH"]/*'/>
public unsafe partial struct IF_COUNTED_STRING_LH
{
    /// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH.Length"]/*'/>
    public ushort Length;
    /// <include file='IF_COUNTED_STRING_LH.xml' path='doc/member[@name="IF_COUNTED_STRING_LH.String"]/*'/>
    [NativeTypeName("WCHAR[257]")]
    public fixed ushort String[257];
}