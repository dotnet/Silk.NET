// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION"]/*'/>
public enum PARSEACTION
{
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_CANONICALIZE"]/*'/>
    PARSE_CANONICALIZE = 1,
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_FRIENDLY"]/*'/>
    PARSE_FRIENDLY = (PARSE_CANONICALIZE + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_SECURITY_URL"]/*'/>
    PARSE_SECURITY_URL = (PARSE_FRIENDLY + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_ROOTDOCUMENT"]/*'/>
    PARSE_ROOTDOCUMENT = (PARSE_SECURITY_URL + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_DOCUMENT"]/*'/>
    PARSE_DOCUMENT = (PARSE_ROOTDOCUMENT + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_ANCHOR"]/*'/>
    PARSE_ANCHOR = (PARSE_DOCUMENT + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_ENCODE_IS_UNESCAPE"]/*'/>
    PARSE_ENCODE_IS_UNESCAPE = (PARSE_ANCHOR + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_DECODE_IS_ESCAPE"]/*'/>
    PARSE_DECODE_IS_ESCAPE = (PARSE_ENCODE_IS_UNESCAPE + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_PATH_FROM_URL"]/*'/>
    PARSE_PATH_FROM_URL = (PARSE_DECODE_IS_ESCAPE + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_URL_FROM_PATH"]/*'/>
    PARSE_URL_FROM_PATH = (PARSE_PATH_FROM_URL + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_MIME"]/*'/>
    PARSE_MIME = (PARSE_URL_FROM_PATH + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_SERVER"]/*'/>
    PARSE_SERVER = (PARSE_MIME + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_SCHEMA"]/*'/>
    PARSE_SCHEMA = (PARSE_SERVER + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_SITE"]/*'/>
    PARSE_SITE = (PARSE_SCHEMA + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_DOMAIN"]/*'/>
    PARSE_DOMAIN = (PARSE_SITE + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_LOCATION"]/*'/>
    PARSE_LOCATION = (PARSE_DOMAIN + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_SECURITY_DOMAIN"]/*'/>
    PARSE_SECURITY_DOMAIN = (PARSE_LOCATION + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_ESCAPE"]/*'/>
    PARSE_ESCAPE = (PARSE_SECURITY_DOMAIN + 1),
    /// <include file='PARSEACTION.xml' path='doc/member[@name="PARSEACTION.PARSE_UNESCAPE"]/*'/>
    PARSE_UNESCAPE = (PARSE_ESCAPE + 1),
}