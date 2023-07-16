// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPDISPLAYPHRASE.xml' path='doc/member[@name="SPDISPLAYPHRASE"]/*'/>
public unsafe partial struct SPDISPLAYPHRASE
{
    /// <include file='SPDISPLAYPHRASE.xml' path='doc/member[@name="SPDISPLAYPHRASE.ulNumTokens"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulNumTokens;
    /// <include file='SPDISPLAYPHRASE.xml' path='doc/member[@name="SPDISPLAYPHRASE.pTokens"]/*'/>
    public SPDISPLAYTOKEN* pTokens;
}