// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions"]/*'/>
public enum WICComponentEnumerateOptions
{
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICComponentEnumerateDefault"]/*'/>
    WICComponentEnumerateDefault = 0,
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICComponentEnumerateRefresh"]/*'/>
    WICComponentEnumerateRefresh = 0x1,
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICComponentEnumerateDisabled"]/*'/>
    WICComponentEnumerateDisabled = unchecked((int)(0x80000000)),
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICComponentEnumerateUnsigned"]/*'/>
    WICComponentEnumerateUnsigned = 0x40000000,
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICComponentEnumerateBuiltInOnly"]/*'/>
    WICComponentEnumerateBuiltInOnly = 0x20000000,
    /// <include file='WICComponentEnumerateOptions.xml' path='doc/member[@name="WICComponentEnumerateOptions.WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD"]/*'/>
    WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD = 0x7fffffff,
}