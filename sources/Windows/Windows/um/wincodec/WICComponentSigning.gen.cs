// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning"]/*'/>
public enum WICComponentSigning
{
    /// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning.WICComponentSigned"]/*'/>
    WICComponentSigned = 0x1,
    /// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning.WICComponentUnsigned"]/*'/>
    WICComponentUnsigned = 0x2,
    /// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning.WICComponentSafe"]/*'/>
    WICComponentSafe = 0x4,
    /// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning.WICComponentDisabled"]/*'/>
    WICComponentDisabled = unchecked((int)(0x80000000)),
    /// <include file='WICComponentSigning.xml' path='doc/member[@name="WICComponentSigning.WICCOMPONENTSIGNING_FORCE_DWORD"]/*'/>
    WICCOMPONENTSIGNING_FORCE_DWORD = 0x7fffffff,
}