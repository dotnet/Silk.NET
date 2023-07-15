// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseOpenViewA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseOpenViewA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szQuery, MSIHANDLE* phView);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseOpenViewW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseOpenViewW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szQuery, MSIHANDLE* phView);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewGetErrorA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBERROR MsiViewGetErrorA(MSIHANDLE hView, [NativeTypeName("LPSTR")] sbyte* szColumnNameBuffer, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewGetErrorW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBERROR MsiViewGetErrorW(MSIHANDLE hView, [NativeTypeName("LPWSTR")] ushort* szColumnNameBuffer, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewExecute"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewExecute(MSIHANDLE hView, MSIHANDLE hRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewFetch"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewFetch(MSIHANDLE hView, MSIHANDLE* phRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewModify"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewModify(MSIHANDLE hView, MSIMODIFY eModifyMode, MSIHANDLE hRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewGetColumnInfo"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewGetColumnInfo(MSIHANDLE hView, MSICOLINFO eColumnInfo, MSIHANDLE* phRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiViewClose"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewClose(MSIHANDLE hView);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseGetPrimaryKeysA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGetPrimaryKeysA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName, MSIHANDLE* phRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseGetPrimaryKeysW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGetPrimaryKeysW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName, MSIHANDLE* phRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseIsTablePersistentA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiDatabaseIsTablePersistentA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseIsTablePersistentW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiDatabaseIsTablePersistentW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetSummaryInformationA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSummaryInformationA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szDatabasePath, uint uiUpdateCount, MSIHANDLE* phSummaryInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetSummaryInformationW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSummaryInformationW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szDatabasePath, uint uiUpdateCount, MSIHANDLE* phSummaryInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoGetPropertyCount"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyCount(MSIHANDLE hSummaryInfo, [NativeTypeName("PUINT")] uint* puiPropertyCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoSetPropertyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoSetPropertyA(MSIHANDLE hSummaryInfo, uint uiProperty, uint uiDataType, int iValue, FILETIME* pftValue, [NativeTypeName("LPCSTR")] sbyte* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoSetPropertyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoSetPropertyW(MSIHANDLE hSummaryInfo, uint uiProperty, uint uiDataType, int iValue, FILETIME* pftValue, [NativeTypeName("LPCWSTR")] ushort* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoGetPropertyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyA(MSIHANDLE hSummaryInfo, uint uiProperty, [NativeTypeName("PUINT")] uint* puiDataType, [NativeTypeName("LPINT")] int* piValue, FILETIME* pftValue, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoGetPropertyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyW(MSIHANDLE hSummaryInfo, uint uiProperty, [NativeTypeName("PUINT")] uint* puiDataType, [NativeTypeName("LPINT")] int* piValue, FILETIME* pftValue, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSummaryInfoPersist"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoPersist(MSIHANDLE hSummaryInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenDatabaseA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenDatabaseA([NativeTypeName("LPCSTR")] sbyte* szDatabasePath, [NativeTypeName("LPCSTR")] sbyte* szPersist, MSIHANDLE* phDatabase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenDatabaseW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenDatabaseW([NativeTypeName("LPCWSTR")] ushort* szDatabasePath, [NativeTypeName("LPCWSTR")] ushort* szPersist, MSIHANDLE* phDatabase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseImportA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseImportA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szFolderPath, [NativeTypeName("LPCSTR")] sbyte* szFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseImportW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseImportW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szFolderPath, [NativeTypeName("LPCWSTR")] ushort* szFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseExportA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseExportA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTableName, [NativeTypeName("LPCSTR")] sbyte* szFolderPath, [NativeTypeName("LPCSTR")] sbyte* szFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseExportW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseExportW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTableName, [NativeTypeName("LPCWSTR")] ushort* szFolderPath, [NativeTypeName("LPCWSTR")] ushort* szFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseMergeA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseMergeA(MSIHANDLE hDatabase, MSIHANDLE hDatabaseMerge, [NativeTypeName("LPCSTR")] sbyte* szTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseMergeW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseMergeW(MSIHANDLE hDatabase, MSIHANDLE hDatabaseMerge, [NativeTypeName("LPCWSTR")] ushort* szTableName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseGenerateTransformA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGenerateTransformA(MSIHANDLE hDatabase, MSIHANDLE hDatabaseReference, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iReserved1, int iReserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseGenerateTransformW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGenerateTransformW(MSIHANDLE hDatabase, MSIHANDLE hDatabaseReference, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iReserved1, int iReserved2);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseApplyTransformA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseApplyTransformA(MSIHANDLE hDatabase, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iErrorConditions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseApplyTransformW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseApplyTransformW(MSIHANDLE hDatabase, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iErrorConditions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCreateTransformSummaryInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCreateTransformSummaryInfoA(MSIHANDLE hDatabase, MSIHANDLE hDatabaseReference, [NativeTypeName("LPCSTR")] sbyte* szTransformFile, int iErrorConditions, int iValidation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCreateTransformSummaryInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCreateTransformSummaryInfoW(MSIHANDLE hDatabase, MSIHANDLE hDatabaseReference, [NativeTypeName("LPCWSTR")] ushort* szTransformFile, int iErrorConditions, int iValidation);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDatabaseCommit"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseCommit(MSIHANDLE hDatabase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetDatabaseState"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBSTATE MsiGetDatabaseState(MSIHANDLE hDatabase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCreateRecord"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIHANDLE MsiCreateRecord(uint cParams);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordIsNull"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern BOOL MsiRecordIsNull(MSIHANDLE hRecord, uint iField);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordDataSize"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordDataSize(MSIHANDLE hRecord, uint iField);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordSetInteger"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetInteger(MSIHANDLE hRecord, uint iField, int iValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordSetStringA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStringA(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPCSTR")] sbyte* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordSetStringW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStringW(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPCWSTR")] ushort* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordGetInteger"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern int MsiRecordGetInteger(MSIHANDLE hRecord, uint iField);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordGetStringA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetStringA(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordGetStringW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetStringW(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordGetFieldCount"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetFieldCount(MSIHANDLE hRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordSetStreamA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStreamA(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPCSTR")] sbyte* szFilePath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordSetStreamW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStreamW(MSIHANDLE hRecord, uint iField, [NativeTypeName("LPCWSTR")] ushort* szFilePath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordReadStream"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordReadStream(MSIHANDLE hRecord, uint iField, [NativeTypeName("char *")] sbyte* szDataBuf, [NativeTypeName("LPDWORD")] uint* pcbDataBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRecordClearData"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordClearData(MSIHANDLE hRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetActiveDatabase"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIHANDLE MsiGetActiveDatabase(MSIHANDLE hInstall);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetPropertyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetPropertyA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szName, [NativeTypeName("LPCSTR")] sbyte* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetPropertyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetPropertyW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szName, [NativeTypeName("LPCWSTR")] ushort* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPropertyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPropertyA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szName, [NativeTypeName("LPSTR")] sbyte* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPropertyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPropertyW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szName, [NativeTypeName("LPWSTR")] ushort* szValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetLanguage"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    [return: NativeTypeName("LANGID")]
    public static extern ushort MsiGetLanguage(MSIHANDLE hInstall);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetMode"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern BOOL MsiGetMode(MSIHANDLE hInstall, MSIRUNMODE eRunMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetMode"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetMode(MSIHANDLE hInstall, MSIRUNMODE eRunMode, BOOL fState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiFormatRecordA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiFormatRecordA(MSIHANDLE hInstall, MSIHANDLE hRecord, [NativeTypeName("LPSTR")] sbyte* szResultBuf, [NativeTypeName("LPDWORD")] uint* pcchResultBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiFormatRecordW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiFormatRecordW(MSIHANDLE hInstall, MSIHANDLE hRecord, [NativeTypeName("LPWSTR")] ushort* szResultBuf, [NativeTypeName("LPDWORD")] uint* pcchResultBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDoActionA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDoActionA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDoActionW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDoActionW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSequenceA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSequenceA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szTable, int iSequenceMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSequenceW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSequenceW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szTable, int iSequenceMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProcessMessage"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern int MsiProcessMessage(MSIHANDLE hInstall, INSTALLMESSAGE eMessageType, MSIHANDLE hRecord);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEvaluateConditionA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiEvaluateConditionA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szCondition);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEvaluateConditionW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiEvaluateConditionW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szCondition);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureStateA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureStateW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetFeatureStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureStateA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE iState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetFeatureStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureStateW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE iState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetFeatureAttributesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureAttributesA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("DWORD")] uint dwAttributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetFeatureAttributesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureAttributesW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("DWORD")] uint dwAttributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetComponentStateA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetComponentStateW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, INSTALLSTATE* piInstalled, INSTALLSTATE* piAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetComponentStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetComponentStateA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, INSTALLSTATE iState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetComponentStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetComponentStateW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, INSTALLSTATE iState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureCostA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureCostA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, MSICOSTTREE iCostTree, INSTALLSTATE iState, [NativeTypeName("LPINT")] int* piCost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureCostW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureCostW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, MSICOSTTREE iCostTree, INSTALLSTATE iState, [NativeTypeName("LPINT")] int* piCost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentCostsA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentCostsA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("DWORD")] uint dwIndex, INSTALLSTATE iState, [NativeTypeName("LPSTR")] sbyte* szDriveBuf, [NativeTypeName("LPDWORD")] uint* pcchDriveBuf, [NativeTypeName("LPINT")] int* piCost, [NativeTypeName("LPINT")] int* piTempCost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentCostsW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentCostsW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("DWORD")] uint dwIndex, INSTALLSTATE iState, [NativeTypeName("LPWSTR")] ushort* szDriveBuf, [NativeTypeName("LPDWORD")] uint* pcchDriveBuf, [NativeTypeName("LPINT")] int* piCost, [NativeTypeName("LPINT")] int* piTempCost);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetInstallLevel"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetInstallLevel(MSIHANDLE hInstall, int iInstallLevel);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureValidStatesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureValidStatesA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("LPDWORD")] uint* lpInstallStates);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureValidStatesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureValidStatesW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("LPDWORD")] uint* lpInstallStates);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetSourcePathA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSourcePathA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPSTR")] sbyte* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetSourcePathW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSourcePathW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPWSTR")] ushort* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetTargetPathA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetTargetPathA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPSTR")] sbyte* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetTargetPathW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetTargetPathW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPWSTR")] ushort* szPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetTargetPathA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetTargetPathA(MSIHANDLE hInstall, [NativeTypeName("LPCSTR")] sbyte* szFolder, [NativeTypeName("LPCSTR")] sbyte* szFolderPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetTargetPathW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetTargetPathW(MSIHANDLE hInstall, [NativeTypeName("LPCWSTR")] ushort* szFolder, [NativeTypeName("LPCWSTR")] ushort* szFolderPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiVerifyDiskSpace"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiVerifyDiskSpace(MSIHANDLE hInstall);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnableUIPreview"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnableUIPreview(MSIHANDLE hDatabase, MSIHANDLE* phPreview);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiPreviewDialogA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewDialogA(MSIHANDLE hPreview, [NativeTypeName("LPCSTR")] sbyte* szDialogName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiPreviewDialogW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewDialogW(MSIHANDLE hPreview, [NativeTypeName("LPCWSTR")] ushort* szDialogName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiPreviewBillboardA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewBillboardA(MSIHANDLE hPreview, [NativeTypeName("LPCSTR")] sbyte* szControlName, [NativeTypeName("LPCSTR")] sbyte* szBillboard);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiPreviewBillboardW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewBillboardW(MSIHANDLE hPreview, [NativeTypeName("LPCWSTR")] ushort* szControlName, [NativeTypeName("LPCWSTR")] ushort* szBillboard);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetLastErrorRecord"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern MSIHANDLE MsiGetLastErrorRecord();
    [NativeTypeName("#define MSI_NULL_INTEGER 0x80000000")]
    public const uint MSI_NULL_INTEGER = 0x80000000;
    [NativeTypeName("#define MSIDBOPEN_READONLY (LPCTSTR)0")]
    public static ushort* MSIDBOPEN_READONLY => (ushort*)(0);

    [NativeTypeName("#define MSIDBOPEN_TRANSACT (LPCTSTR)1")]
    public static ushort* MSIDBOPEN_TRANSACT => (ushort*)(1);

    [NativeTypeName("#define MSIDBOPEN_DIRECT (LPCTSTR)2")]
    public static ushort* MSIDBOPEN_DIRECT => (ushort*)(2);

    [NativeTypeName("#define MSIDBOPEN_CREATE (LPCTSTR)3")]
    public static ushort* MSIDBOPEN_CREATE => (ushort*)(3);

    [NativeTypeName("#define MSIDBOPEN_CREATEDIRECT (LPCTSTR)4")]
    public static ushort* MSIDBOPEN_CREATEDIRECT => (ushort*)(4);

    [NativeTypeName("#define MSIDBOPEN_PATCHFILE 32/sizeof(*MSIDBOPEN_READONLY)")]
    public const uint MSIDBOPEN_PATCHFILE = 32 / 2;
    [NativeTypeName("#define INSTALLMESSAGE_TYPEMASK 0xFF000000L")]
    public const uint INSTALLMESSAGE_TYPEMASK = 0xFF000000;
    [NativeTypeName("#define MsiDatabaseOpenView MsiDatabaseOpenViewW")]
    public static delegate*<MSIHANDLE, ushort*, MSIHANDLE*, uint> MsiDatabaseOpenView => &MsiDatabaseOpenViewW;

    [NativeTypeName("#define MsiViewGetError MsiViewGetErrorW")]
    public static delegate*<MSIHANDLE, ushort*, uint*, MSIDBERROR> MsiViewGetError => &MsiViewGetErrorW;

    [NativeTypeName("#define MsiDatabaseGetPrimaryKeys MsiDatabaseGetPrimaryKeysW")]
    public static delegate*<MSIHANDLE, ushort*, MSIHANDLE*, uint> MsiDatabaseGetPrimaryKeys => &MsiDatabaseGetPrimaryKeysW;

    [NativeTypeName("#define MsiDatabaseIsTablePersistent MsiDatabaseIsTablePersistentW")]
    public static delegate*<MSIHANDLE, ushort*, MSICONDITION> MsiDatabaseIsTablePersistent => &MsiDatabaseIsTablePersistentW;

    [NativeTypeName("#define MsiGetSummaryInformation MsiGetSummaryInformationW")]
    public static delegate*<MSIHANDLE, ushort*, uint, MSIHANDLE*, uint> MsiGetSummaryInformation => &MsiGetSummaryInformationW;

    [NativeTypeName("#define MsiSummaryInfoSetProperty MsiSummaryInfoSetPropertyW")]
    public static delegate*<MSIHANDLE, uint, uint, int, FILETIME*, ushort*, uint> MsiSummaryInfoSetProperty => &MsiSummaryInfoSetPropertyW;

    [NativeTypeName("#define MsiSummaryInfoGetProperty MsiSummaryInfoGetPropertyW")]
    public static delegate*<MSIHANDLE, uint, uint*, int*, FILETIME*, ushort*, uint*, uint> MsiSummaryInfoGetProperty => &MsiSummaryInfoGetPropertyW;

    [NativeTypeName("#define MsiOpenDatabase MsiOpenDatabaseW")]
    public static delegate*<ushort*, ushort*, MSIHANDLE*, uint> MsiOpenDatabase => &MsiOpenDatabaseW;

    [NativeTypeName("#define MsiDatabaseImport MsiDatabaseImportW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint> MsiDatabaseImport => &MsiDatabaseImportW;

    [NativeTypeName("#define MsiDatabaseExport MsiDatabaseExportW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, ushort*, uint> MsiDatabaseExport => &MsiDatabaseExportW;

    [NativeTypeName("#define MsiDatabaseMerge MsiDatabaseMergeW")]
    public static delegate*<MSIHANDLE, MSIHANDLE, ushort*, uint> MsiDatabaseMerge => &MsiDatabaseMergeW;

    [NativeTypeName("#define MsiDatabaseGenerateTransform MsiDatabaseGenerateTransformW")]
    public static delegate*<MSIHANDLE, MSIHANDLE, ushort*, int, int, uint> MsiDatabaseGenerateTransform => &MsiDatabaseGenerateTransformW;

    [NativeTypeName("#define MsiDatabaseApplyTransform MsiDatabaseApplyTransformW")]
    public static delegate*<MSIHANDLE, ushort*, int, uint> MsiDatabaseApplyTransform => &MsiDatabaseApplyTransformW;

    [NativeTypeName("#define MsiCreateTransformSummaryInfo MsiCreateTransformSummaryInfoW")]
    public static delegate*<MSIHANDLE, MSIHANDLE, ushort*, int, int, uint> MsiCreateTransformSummaryInfo => &MsiCreateTransformSummaryInfoW;

    [NativeTypeName("#define MsiRecordSetString MsiRecordSetStringW")]
    public static delegate*<MSIHANDLE, uint, ushort*, uint> MsiRecordSetString => &MsiRecordSetStringW;

    [NativeTypeName("#define MsiRecordGetString MsiRecordGetStringW")]
    public static delegate*<MSIHANDLE, uint, ushort*, uint*, uint> MsiRecordGetString => &MsiRecordGetStringW;

    [NativeTypeName("#define MsiRecordSetStream MsiRecordSetStreamW")]
    public static delegate*<MSIHANDLE, uint, ushort*, uint> MsiRecordSetStream => &MsiRecordSetStreamW;

    [NativeTypeName("#define MsiSetProperty MsiSetPropertyW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint> MsiSetProperty => &MsiSetPropertyW;

    [NativeTypeName("#define MsiGetProperty MsiGetPropertyW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetProperty => &MsiGetPropertyW;

    [NativeTypeName("#define MsiFormatRecord MsiFormatRecordW")]
    public static delegate*<MSIHANDLE, MSIHANDLE, ushort*, uint*, uint> MsiFormatRecord => &MsiFormatRecordW;

    [NativeTypeName("#define MsiDoAction MsiDoActionW")]
    public static delegate*<MSIHANDLE, ushort*, uint> MsiDoAction => &MsiDoActionW;

    [NativeTypeName("#define MsiSequence MsiSequenceW")]
    public static delegate*<MSIHANDLE, ushort*, int, uint> MsiSequence => &MsiSequenceW;

    [NativeTypeName("#define MsiEvaluateCondition MsiEvaluateConditionW")]
    public static delegate*<MSIHANDLE, ushort*, MSICONDITION> MsiEvaluateCondition => &MsiEvaluateConditionW;

    [NativeTypeName("#define MsiGetFeatureState MsiGetFeatureStateW")]
    public static delegate*<MSIHANDLE, ushort*, INSTALLSTATE*, INSTALLSTATE*, uint> MsiGetFeatureState => &MsiGetFeatureStateW;

    [NativeTypeName("#define MsiSetFeatureState MsiSetFeatureStateW")]
    public static delegate*<MSIHANDLE, ushort*, INSTALLSTATE, uint> MsiSetFeatureState => &MsiSetFeatureStateW;

    [NativeTypeName("#define MsiSetFeatureAttributes MsiSetFeatureAttributesW")]
    public static delegate*<MSIHANDLE, ushort*, uint, uint> MsiSetFeatureAttributes => &MsiSetFeatureAttributesW;

    [NativeTypeName("#define MsiGetComponentState MsiGetComponentStateW")]
    public static delegate*<MSIHANDLE, ushort*, INSTALLSTATE*, INSTALLSTATE*, uint> MsiGetComponentState => &MsiGetComponentStateW;

    [NativeTypeName("#define MsiSetComponentState MsiSetComponentStateW")]
    public static delegate*<MSIHANDLE, ushort*, INSTALLSTATE, uint> MsiSetComponentState => &MsiSetComponentStateW;

    [NativeTypeName("#define MsiGetFeatureCost MsiGetFeatureCostW")]
    public static delegate*<MSIHANDLE, ushort*, MSICOSTTREE, INSTALLSTATE, int*, uint> MsiGetFeatureCost => &MsiGetFeatureCostW;

    [NativeTypeName("#define MsiEnumComponentCosts MsiEnumComponentCostsW")]
    public static delegate*<MSIHANDLE, ushort*, uint, INSTALLSTATE, ushort*, uint*, int*, int*, uint> MsiEnumComponentCosts => &MsiEnumComponentCostsW;

    [NativeTypeName("#define MsiGetFeatureValidStates MsiGetFeatureValidStatesW")]
    public static delegate*<MSIHANDLE, ushort*, uint*, uint> MsiGetFeatureValidStates => &MsiGetFeatureValidStatesW;

    [NativeTypeName("#define MsiGetSourcePath MsiGetSourcePathW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetSourcePath => &MsiGetSourcePathW;

    [NativeTypeName("#define MsiGetTargetPath MsiGetTargetPathW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetTargetPath => &MsiGetTargetPathW;

    [NativeTypeName("#define MsiSetTargetPath MsiSetTargetPathW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint> MsiSetTargetPath => &MsiSetTargetPathW;

    [NativeTypeName("#define MsiPreviewDialog MsiPreviewDialogW")]
    public static delegate*<MSIHANDLE, ushort*, uint> MsiPreviewDialog => &MsiPreviewDialogW;

    [NativeTypeName("#define MsiPreviewBillboard MsiPreviewBillboardW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint> MsiPreviewBillboard => &MsiPreviewBillboardW;
}