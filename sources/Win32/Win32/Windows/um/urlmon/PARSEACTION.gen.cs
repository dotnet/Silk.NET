// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PARSEACTION
{
    PARSE_CANONICALIZE = 1,
    PARSE_FRIENDLY = (PARSE_CANONICALIZE + 1),
    PARSE_SECURITY_URL = (PARSE_FRIENDLY + 1),
    PARSE_ROOTDOCUMENT = (PARSE_SECURITY_URL + 1),
    PARSE_DOCUMENT = (PARSE_ROOTDOCUMENT + 1),
    PARSE_ANCHOR = (PARSE_DOCUMENT + 1),
    PARSE_ENCODE_IS_UNESCAPE = (PARSE_ANCHOR + 1),
    PARSE_DECODE_IS_ESCAPE = (PARSE_ENCODE_IS_UNESCAPE + 1),
    PARSE_PATH_FROM_URL = (PARSE_DECODE_IS_ESCAPE + 1),
    PARSE_URL_FROM_PATH = (PARSE_PATH_FROM_URL + 1),
    PARSE_MIME = (PARSE_URL_FROM_PATH + 1),
    PARSE_SERVER = (PARSE_MIME + 1),
    PARSE_SCHEMA = (PARSE_SERVER + 1),
    PARSE_SITE = (PARSE_SCHEMA + 1),
    PARSE_DOMAIN = (PARSE_SITE + 1),
    PARSE_LOCATION = (PARSE_DOMAIN + 1),
    PARSE_SECURITY_DOMAIN = (PARSE_LOCATION + 1),
    PARSE_ESCAPE = (PARSE_SECURITY_DOMAIN + 1),
    PARSE_UNESCAPE = (PARSE_ESCAPE + 1),
}
