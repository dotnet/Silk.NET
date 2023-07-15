// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class STR
{
    [NativeTypeName("#define STR_BIND_FORCE_FOLDER_SHORTCUT_RESOLVE L\"Force Folder Shortcut Resolve\"")]
    public const string STR_BIND_FORCE_FOLDER_SHORTCUT_RESOLVE = "Force Folder Shortcut Resolve";
    [NativeTypeName("#define STR_AVOID_DRIVE_RESTRICTION_POLICY L\"Avoid Drive Restriction Policy\"")]
    public const string STR_AVOID_DRIVE_RESTRICTION_POLICY = "Avoid Drive Restriction Policy";
    [NativeTypeName("#define STR_SKIP_BINDING_CLSID L\"Skip Binding CLSID\"")]
    public const string STR_SKIP_BINDING_CLSID = "Skip Binding CLSID";
    [NativeTypeName("#define STR_PARSE_PREFER_FOLDER_BROWSING L\"Parse Prefer Folder Browsing\"")]
    public const string STR_PARSE_PREFER_FOLDER_BROWSING = "Parse Prefer Folder Browsing";
    [NativeTypeName("#define STR_DONT_PARSE_RELATIVE L\"Don't Parse Relative\"")]
    public const string STR_DONT_PARSE_RELATIVE = "Don't Parse Relative";
    [NativeTypeName("#define STR_PARSE_TRANSLATE_ALIASES L\"Parse Translate Aliases\"")]
    public const string STR_PARSE_TRANSLATE_ALIASES = "Parse Translate Aliases";
    [NativeTypeName("#define STR_PARSE_SKIP_NET_CACHE L\"Skip Net Resource Cache\"")]
    public const string STR_PARSE_SKIP_NET_CACHE = "Skip Net Resource Cache";
    [NativeTypeName("#define STR_PARSE_SHELL_PROTOCOL_TO_FILE_OBJECTS L\"Parse Shell Protocol To File Objects\"")]
    public const string STR_PARSE_SHELL_PROTOCOL_TO_FILE_OBJECTS = "Parse Shell Protocol To File Objects";
    [NativeTypeName("#define STR_TRACK_CLSID L\"Track the CLSID\"")]
    public const string STR_TRACK_CLSID = "Track the CLSID";
    [NativeTypeName("#define STR_INTERNAL_NAVIGATE L\"Internal Navigation\"")]
    public const string STR_INTERNAL_NAVIGATE = "Internal Navigation";
    [NativeTypeName("#define STR_PARSE_PROPERTYSTORE L\"DelegateNamedProperties\"")]
    public const string STR_PARSE_PROPERTYSTORE = "DelegateNamedProperties";
    [NativeTypeName("#define STR_NO_VALIDATE_FILENAME_CHARS L\"NoValidateFilenameChars\"")]
    public const string STR_NO_VALIDATE_FILENAME_CHARS = "NoValidateFilenameChars";
    [NativeTypeName("#define STR_BIND_DELEGATE_CREATE_OBJECT L\"Delegate Object Creation\"")]
    public const string STR_BIND_DELEGATE_CREATE_OBJECT = "Delegate Object Creation";
    [NativeTypeName("#define STR_PARSE_ALLOW_INTERNET_SHELL_FOLDERS L\"Allow binding to Internet shell folder handlers and negate STR_PARSE_PREFER_WEB_BROWSING\"")]
    public const string STR_PARSE_ALLOW_INTERNET_SHELL_FOLDERS = "Allow binding to Internet shell folder handlers and negate STR_PARSE_PREFER_WEB_BROWSING";
    [NativeTypeName("#define STR_PARSE_PREFER_WEB_BROWSING L\"Do not bind to Internet shell folder handlers\"")]
    public const string STR_PARSE_PREFER_WEB_BROWSING = "Do not bind to Internet shell folder handlers";
    [NativeTypeName("#define STR_PARSE_SHOW_NET_DIAGNOSTICS_UI L\"Show network diagnostics UI\"")]
    public const string STR_PARSE_SHOW_NET_DIAGNOSTICS_UI = "Show network diagnostics UI";
    [NativeTypeName("#define STR_PARSE_DONT_REQUIRE_VALIDATED_URLS L\"Do not require validated URLs\"")]
    public const string STR_PARSE_DONT_REQUIRE_VALIDATED_URLS = "Do not require validated URLs";
    [NativeTypeName("#define STR_INTERNETFOLDER_PARSE_ONLY_URLMON_BINDABLE L\"Validate URL\"")]
    public const string STR_INTERNETFOLDER_PARSE_ONLY_URLMON_BINDABLE = "Validate URL";
    [NativeTypeName("#define STR_BIND_FOLDERS_READ_ONLY L\"Folders As Read Only\"")]
    public const string STR_BIND_FOLDERS_READ_ONLY = "Folders As Read Only";
    [NativeTypeName("#define STR_BIND_FOLDER_ENUM_MODE L\"Folder Enum Mode\"")]
    public const string STR_BIND_FOLDER_ENUM_MODE = "Folder Enum Mode";
    [NativeTypeName("#define STR_PARSE_WITH_EXPLICIT_PROGID L\"ExplicitProgid\"")]
    public const string STR_PARSE_WITH_EXPLICIT_PROGID = "ExplicitProgid";
    [NativeTypeName("#define STR_PARSE_WITH_EXPLICIT_ASSOCAPP L\"ExplicitAssociationApp\"")]
    public const string STR_PARSE_WITH_EXPLICIT_ASSOCAPP = "ExplicitAssociationApp";
    [NativeTypeName("#define STR_PARSE_EXPLICIT_ASSOCIATION_SUCCESSFUL L\"ExplicitAssociationSuccessful\"")]
    public const string STR_PARSE_EXPLICIT_ASSOCIATION_SUCCESSFUL = "ExplicitAssociationSuccessful";
    [NativeTypeName("#define STR_PARSE_AND_CREATE_ITEM L\"ParseAndCreateItem\"")]
    public const string STR_PARSE_AND_CREATE_ITEM = "ParseAndCreateItem";
    [NativeTypeName("#define STR_PROPERTYBAG_PARAM L\"SHBindCtxPropertyBag\"")]
    public const string STR_PROPERTYBAG_PARAM = "SHBindCtxPropertyBag";
    [NativeTypeName("#define STR_ENUM_ITEMS_FLAGS L\"SHCONTF\"")]
    public const string STR_ENUM_ITEMS_FLAGS = "SHCONTF";
    [NativeTypeName("#define STR_STORAGEITEM_CREATION_FLAGS L\"SHGETSTORAGEITEM\"")]
    public const string STR_STORAGEITEM_CREATION_FLAGS = "SHGETSTORAGEITEM";
    [NativeTypeName("#define STR_ITEM_CACHE_CONTEXT L\"ItemCacheContext\"")]
    public const string STR_ITEM_CACHE_CONTEXT = "ItemCacheContext";
    [NativeTypeName("#define STR_DONT_RESOLVE_LINK L\"Don't Resolve Link\"")]
    public const string STR_DONT_RESOLVE_LINK = "Don't Resolve Link";
    [NativeTypeName("#define STR_GET_ASYNC_HANDLER L\"GetAsyncHandler\"")]
    public const string STR_GET_ASYNC_HANDLER = "GetAsyncHandler";
    [NativeTypeName("#define STR_GPS_HANDLERPROPERTIESONLY L\"GPS_HANDLERPROPERTIESONLY\"")]
    public const string STR_GPS_HANDLERPROPERTIESONLY = "GPS_HANDLERPROPERTIESONLY";
    [NativeTypeName("#define STR_GPS_FASTPROPERTIESONLY L\"GPS_FASTPROPERTIESONLY\"")]
    public const string STR_GPS_FASTPROPERTIESONLY = "GPS_FASTPROPERTIESONLY";
    [NativeTypeName("#define STR_GPS_OPENSLOWITEM L\"GPS_OPENSLOWITEM\"")]
    public const string STR_GPS_OPENSLOWITEM = "GPS_OPENSLOWITEM";
    [NativeTypeName("#define STR_GPS_DELAYCREATION L\"GPS_DELAYCREATION\"")]
    public const string STR_GPS_DELAYCREATION = "GPS_DELAYCREATION";
    [NativeTypeName("#define STR_GPS_BESTEFFORT L\"GPS_BESTEFFORT\"")]
    public const string STR_GPS_BESTEFFORT = "GPS_BESTEFFORT";
    [NativeTypeName("#define STR_GPS_NO_OPLOCK L\"GPS_NO_OPLOCK\"")]
    public const string STR_GPS_NO_OPLOCK = "GPS_NO_OPLOCK";
    [NativeTypeName("#define STR_FILE_SYS_BIND_DATA L\"File System Bind Data\"")]
    public const string STR_FILE_SYS_BIND_DATA = "File System Bind Data";
    [NativeTypeName("#define STR_FILE_SYS_BIND_DATA_WIN7_FORMAT L\"Win7FileSystemIdList\"")]
    public const string STR_FILE_SYS_BIND_DATA_WIN7_FORMAT = "Win7FileSystemIdList";
    [NativeTypeName("#define STR_TAB_REUSE_IDENTIFIER L\"Tab Reuse Identifier\"")]
    public const string STR_TAB_REUSE_IDENTIFIER = "Tab Reuse Identifier";
    [NativeTypeName("#define STR_REFERRER_IDENTIFIER L\"Referrer Identifier\"")]
    public const string STR_REFERRER_IDENTIFIER = "Referrer Identifier";
}