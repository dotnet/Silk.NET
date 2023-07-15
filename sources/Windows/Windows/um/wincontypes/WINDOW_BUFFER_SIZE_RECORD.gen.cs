// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINDOW_BUFFER_SIZE_RECORD.xml' path='doc/member[@name="WINDOW_BUFFER_SIZE_RECORD"]/*'/>
public partial struct WINDOW_BUFFER_SIZE_RECORD
{
    /// <include file='WINDOW_BUFFER_SIZE_RECORD.xml' path='doc/member[@name="WINDOW_BUFFER_SIZE_RECORD.dwSize"]/*'/>
    public COORD dwSize;
}