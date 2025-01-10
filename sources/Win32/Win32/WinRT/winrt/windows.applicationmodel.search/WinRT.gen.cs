// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ILocalContentSuggestionSettings =
        "Windows.ApplicationModel.Search.ILocalContentSuggestionSettings";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPane =
        "Windows.ApplicationModel.Search.ISearchPane";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneQueryChangedEventArgs =
        "Windows.ApplicationModel.Search.ISearchPaneQueryChangedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneQueryLinguisticDetails =
        "Windows.ApplicationModel.Search.ISearchPaneQueryLinguisticDetails";

    [NativeTypeName("const WCHAR[67]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneQuerySubmittedEventArgs =
        "Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgs";

    [NativeTypeName("const WCHAR[88]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails =
        "Windows.ApplicationModel.Search.ISearchPaneQuerySubmittedEventArgsWithLinguisticDetails";

    [NativeTypeName("const WCHAR[75]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneResultSuggestionChosenEventArgs =
        "Windows.ApplicationModel.Search.ISearchPaneResultSuggestionChosenEventArgs";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneStatics =
        "Windows.ApplicationModel.Search.ISearchPaneStatics";

    [NativeTypeName("const WCHAR[74]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneStaticsWithHideThisApplication =
        "Windows.ApplicationModel.Search.ISearchPaneStaticsWithHideThisApplication";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneSuggestionsRequest =
        "Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequest";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneSuggestionsRequestDeferral =
        "Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestDeferral";

    [NativeTypeName("const WCHAR[73]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneSuggestionsRequestedEventArgs =
        "Windows.ApplicationModel.Search.ISearchPaneSuggestionsRequestedEventArgs";

    [NativeTypeName("const WCHAR[70]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchPaneVisibilityChangedEventArgs =
        "Windows.ApplicationModel.Search.ISearchPaneVisibilityChangedEventArgs";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchQueryLinguisticDetails =
        "Windows.ApplicationModel.Search.ISearchQueryLinguisticDetails";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchQueryLinguisticDetailsFactory =
        "Windows.ApplicationModel.Search.ISearchQueryLinguisticDetailsFactory";

    [NativeTypeName("const WCHAR[60]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchSuggestionCollection =
        "Windows.ApplicationModel.Search.ISearchSuggestionCollection";

    [NativeTypeName("const WCHAR[58]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchSuggestionsRequest =
        "Windows.ApplicationModel.Search.ISearchSuggestionsRequest";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_ApplicationModel_Search_ISearchSuggestionsRequestDeferral =
        "Windows.ApplicationModel.Search.ISearchSuggestionsRequestDeferral";

    [NativeTypeName("const WCHAR[63]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_LocalContentSuggestionSettings =
        "Windows.ApplicationModel.Search.LocalContentSuggestionSettings";

    [NativeTypeName("const WCHAR[43]")]
    [Obsolete("SearchPane may be altered or unavailable for releases after Windows 10.")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPane =
        "Windows.ApplicationModel.Search.SearchPane";

    [NativeTypeName("const WCHAR[64]")]
    [Obsolete(
        "SearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneQueryChangedEventArgs =
        "Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneQueryLinguisticDetails =
        "Windows.ApplicationModel.Search.SearchPaneQueryLinguisticDetails";

    [NativeTypeName("const WCHAR[66]")]
    [Obsolete(
        "SearchPaneQuerySubmittedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneQuerySubmittedEventArgs =
        "Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs";

    [NativeTypeName("const WCHAR[74]")]
    [Obsolete(
        "SearchPaneResultSuggestionChosenEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneResultSuggestionChosenEventArgs =
        "Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    [Obsolete(
        "SearchPaneSuggestionsRequest may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneSuggestionsRequest =
        "Windows.ApplicationModel.Search.SearchPaneSuggestionsRequest";

    [NativeTypeName("const WCHAR[69]")]
    [Obsolete(
        "SearchPaneSuggestionsRequestDeferral may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneSuggestionsRequestDeferral =
        "Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestDeferral";

    [NativeTypeName("const WCHAR[72]")]
    [Obsolete(
        "SearchPaneSuggestionsRequestedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneSuggestionsRequestedEventArgs =
        "Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs";

    [NativeTypeName("const WCHAR[69]")]
    [Obsolete(
        "SearchPaneVisibilityChangedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchPaneVisibilityChangedEventArgs =
        "Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchQueryLinguisticDetails =
        "Windows.ApplicationModel.Search.SearchQueryLinguisticDetails";

    [NativeTypeName("const WCHAR[59]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchSuggestionCollection =
        "Windows.ApplicationModel.Search.SearchSuggestionCollection";

    [NativeTypeName("const WCHAR[57]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchSuggestionsRequest =
        "Windows.ApplicationModel.Search.SearchSuggestionsRequest";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_ApplicationModel_Search_SearchSuggestionsRequestDeferral =
        "Windows.ApplicationModel.Search.SearchSuggestionsRequestDeferral";

    [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_SEARCH_SEARCHCONTRACT_VERSION 0x10000")]
    public const int WINDOWS_APPLICATIONMODEL_SEARCH_SEARCHCONTRACT_VERSION = 0x10000;
}
