// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COMDLG_FILTERSPEC.xml' path='doc/member[@name="COMDLG_FILTERSPEC"]/*' />
public unsafe partial struct COMDLG_FILTERSPEC
{
    /// <include file='COMDLG_FILTERSPEC.xml' path='doc/member[@name="COMDLG_FILTERSPEC.pszName"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszName;

    /// <include file='COMDLG_FILTERSPEC.xml' path='doc/member[@name="COMDLG_FILTERSPEC.pszSpec"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszSpec;
}
