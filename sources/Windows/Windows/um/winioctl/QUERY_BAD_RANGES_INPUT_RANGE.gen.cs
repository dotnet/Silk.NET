// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='QUERY_BAD_RANGES_INPUT_RANGE.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT_RANGE"]/*'/>
public partial struct QUERY_BAD_RANGES_INPUT_RANGE
{
    /// <include file='QUERY_BAD_RANGES_INPUT_RANGE.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT_RANGE.StartOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong StartOffset;
    /// <include file='QUERY_BAD_RANGES_INPUT_RANGE.xml' path='doc/member[@name="QUERY_BAD_RANGES_INPUT_RANGE.LengthInBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LengthInBytes;
}