// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT"]/*'/>
public unsafe partial struct GET_FILTER_FILE_IDENTIFIER_INPUT
{
    /// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT.AltitudeLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort AltitudeLength;
    /// <include file='GET_FILTER_FILE_IDENTIFIER_INPUT.xml' path='doc/member[@name="GET_FILTER_FILE_IDENTIFIER_INPUT.Altitude"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Altitude[1];
}