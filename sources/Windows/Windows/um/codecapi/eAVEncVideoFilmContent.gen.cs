// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVEncVideoFilmContent.xml' path='doc/member[@name="eAVEncVideoFilmContent"]/*'/>
public enum eAVEncVideoFilmContent
{
    /// <include file='eAVEncVideoFilmContent.xml' path='doc/member[@name="eAVEncVideoFilmContent.eAVEncVideoFilmContent_VideoOnly"]/*'/>
    eAVEncVideoFilmContent_VideoOnly = 0,
    /// <include file='eAVEncVideoFilmContent.xml' path='doc/member[@name="eAVEncVideoFilmContent.eAVEncVideoFilmContent_FilmOnly"]/*'/>
    eAVEncVideoFilmContent_FilmOnly = 1,
    /// <include file='eAVEncVideoFilmContent.xml' path='doc/member[@name="eAVEncVideoFilmContent.eAVEncVideoFilmContent_Mixed"]/*'/>
    eAVEncVideoFilmContent_Mixed = 2,
}