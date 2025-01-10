// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[78]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_Core_IRequestingFocusOnKeyboardInputEventArgs =
        "Windows.ApplicationModel.Search.Core.IRequestingFocusOnKeyboardInputEventArgs";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_Core_ISearchSuggestion =
        "Windows.ApplicationModel.Search.Core.ISearchSuggestion";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_Core_ISearchSuggestionManager =
        "Windows.ApplicationModel.Search.Core.ISearchSuggestionManager";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_Core_ISearchSuggestionsRequestedEventArgs =
        "Windows.ApplicationModel.Search.Core.ISearchSuggestionsRequestedEventArgs";

    [NativeTypeName("const WCHAR[77]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_Core_RequestingFocusOnKeyboardInputEventArgs =
        "Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_Core_SearchSuggestion =
        "Windows.ApplicationModel.Search.Core.SearchSuggestion";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_Core_SearchSuggestionManager =
        "Windows.ApplicationModel.Search.Core.SearchSuggestionManager";

    [NativeTypeName("const WCHAR[73]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_Core_SearchSuggestionsRequestedEventArgs =
        "Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs";

    [NativeTypeName(
        "#define WINDOWS_APPLICATIONMODEL_SEARCH_CORE_SEARCHCORECONTRACT_VERSION 0x10000"
    )]
    public const int WINDOWS_APPLICATIONMODEL_SEARCH_CORE_SEARCHCORECONTRACT_VERSION = 0x10000;
}
