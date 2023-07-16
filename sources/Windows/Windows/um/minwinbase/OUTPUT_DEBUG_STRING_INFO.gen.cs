// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OUTPUT_DEBUG_STRING_INFO.xml' path='doc/member[@name="OUTPUT_DEBUG_STRING_INFO"]/*'/>
public unsafe partial struct OUTPUT_DEBUG_STRING_INFO
{
    /// <include file='OUTPUT_DEBUG_STRING_INFO.xml' path='doc/member[@name="OUTPUT_DEBUG_STRING_INFO.lpDebugStringData"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpDebugStringData;
    /// <include file='OUTPUT_DEBUG_STRING_INFO.xml' path='doc/member[@name="OUTPUT_DEBUG_STRING_INFO.fUnicode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort fUnicode;
    /// <include file='OUTPUT_DEBUG_STRING_INFO.xml' path='doc/member[@name="OUTPUT_DEBUG_STRING_INFO.nDebugStringLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nDebugStringLength;
}