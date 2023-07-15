// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DVD_SUBPICTURE_CODING.xml' path='doc/member[@name="DVD_SUBPICTURE_CODING"]/*'/>
public enum DVD_SUBPICTURE_CODING
{
    /// <include file='DVD_SUBPICTURE_CODING.xml' path='doc/member[@name="DVD_SUBPICTURE_CODING.DVD_SPCoding_RunLength"]/*'/>
    DVD_SPCoding_RunLength = 0,
    /// <include file='DVD_SUBPICTURE_CODING.xml' path='doc/member[@name="DVD_SUBPICTURE_CODING.DVD_SPCoding_Extended"]/*'/>
    DVD_SPCoding_Extended = 1,
    /// <include file='DVD_SUBPICTURE_CODING.xml' path='doc/member[@name="DVD_SUBPICTURE_CODING.DVD_SPCoding_Other"]/*'/>
    DVD_SPCoding_Other = 2,
}