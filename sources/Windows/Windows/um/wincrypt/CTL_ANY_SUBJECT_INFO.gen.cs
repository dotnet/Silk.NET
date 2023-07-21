// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CTL_ANY_SUBJECT_INFO.xml' path='doc/member[@name="CTL_ANY_SUBJECT_INFO"]/*' />
public partial struct CTL_ANY_SUBJECT_INFO
{
    /// <include file='CTL_ANY_SUBJECT_INFO.xml' path='doc/member[@name="CTL_ANY_SUBJECT_INFO.SubjectAlgorithm"]/*' />
    public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;

    /// <include file='CTL_ANY_SUBJECT_INFO.xml' path='doc/member[@name="CTL_ANY_SUBJECT_INFO.SubjectIdentifier"]/*' />
    public CRYPT_DATA_BLOB SubjectIdentifier;
}
