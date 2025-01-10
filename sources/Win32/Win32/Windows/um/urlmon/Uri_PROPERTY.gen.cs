// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum Uri_PROPERTY
{
    Uri_PROPERTY_ABSOLUTE_URI = 0,
    Uri_PROPERTY_STRING_START = Uri_PROPERTY_ABSOLUTE_URI,
    Uri_PROPERTY_AUTHORITY = 1,
    Uri_PROPERTY_DISPLAY_URI = 2,
    Uri_PROPERTY_DOMAIN = 3,
    Uri_PROPERTY_EXTENSION = 4,
    Uri_PROPERTY_FRAGMENT = 5,
    Uri_PROPERTY_HOST = 6,
    Uri_PROPERTY_PASSWORD = 7,
    Uri_PROPERTY_PATH = 8,
    Uri_PROPERTY_PATH_AND_QUERY = 9,
    Uri_PROPERTY_QUERY = 10,
    Uri_PROPERTY_RAW_URI = 11,
    Uri_PROPERTY_SCHEME_NAME = 12,
    Uri_PROPERTY_USER_INFO = 13,
    Uri_PROPERTY_USER_NAME = 14,
    Uri_PROPERTY_STRING_LAST = Uri_PROPERTY_USER_NAME,
    Uri_PROPERTY_HOST_TYPE = 15,
    Uri_PROPERTY_DWORD_START = Uri_PROPERTY_HOST_TYPE,
    Uri_PROPERTY_PORT = 16,
    Uri_PROPERTY_SCHEME = 17,
    Uri_PROPERTY_ZONE = 18,
    Uri_PROPERTY_DWORD_LAST = Uri_PROPERTY_ZONE,
}
