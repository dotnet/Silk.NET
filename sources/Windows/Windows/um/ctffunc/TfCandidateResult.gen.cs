// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TfCandidateResult.xml' path='doc/member[@name="TfCandidateResult"]/*' />
public enum TfCandidateResult
{
    /// <include file='TfCandidateResult.xml' path='doc/member[@name="TfCandidateResult.CAND_FINALIZED"]/*' />
    CAND_FINALIZED = 0,

    /// <include file='TfCandidateResult.xml' path='doc/member[@name="TfCandidateResult.CAND_SELECTED"]/*' />
    CAND_SELECTED = 0x1,

    /// <include file='TfCandidateResult.xml' path='doc/member[@name="TfCandidateResult.CAND_CANCELED"]/*' />
    CAND_CANCELED = 0x2,
}
