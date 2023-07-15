// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CSV_IS_OWNED_BY_CSVFS.xml' path='doc/member[@name="CSV_IS_OWNED_BY_CSVFS"]/*'/>
public partial struct CSV_IS_OWNED_BY_CSVFS
{
    /// <include file='CSV_IS_OWNED_BY_CSVFS.xml' path='doc/member[@name="CSV_IS_OWNED_BY_CSVFS.OwnedByCSVFS"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte OwnedByCSVFS;
}