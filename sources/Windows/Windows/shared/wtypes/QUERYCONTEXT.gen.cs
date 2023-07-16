// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT"]/*'/>
public partial struct QUERYCONTEXT
{
    /// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT.dwContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwContext;
    /// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT.Platform"]/*'/>
    public CSPLATFORM Platform;
    /// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT.Locale"]/*'/>
    [NativeTypeName("LCID")]
    public uint Locale;
    /// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT.dwVersionHi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersionHi;
    /// <include file='QUERYCONTEXT.xml' path='doc/member[@name="QUERYCONTEXT.dwVersionLo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersionLo;
}