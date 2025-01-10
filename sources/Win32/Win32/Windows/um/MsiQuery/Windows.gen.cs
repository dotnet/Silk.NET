// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("msi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint MsiDatabaseOpenViewA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szQuery,
        MSIHANDLE* phView
    );

    [DllImport("msi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint MsiDatabaseOpenViewW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szQuery,
        MSIHANDLE* phView
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBERROR MsiViewGetErrorA(
        MSIHANDLE hView,
        [NativeTypeName("LPSTR")] sbyte* szColumnNameBuffer,
        [NativeTypeName("LPDWORD")] uint* pcchBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBERROR MsiViewGetErrorW(
        MSIHANDLE hView,
        [NativeTypeName("LPWSTR")] ushort* szColumnNameBuffer,
        [NativeTypeName("LPDWORD")] uint* pcchBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewExecute(MSIHANDLE hView, MSIHANDLE hRecord);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewFetch(MSIHANDLE hView, MSIHANDLE* phRecord);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewModify(
        MSIHANDLE hView,
        MSIMODIFY eModifyMode,
        MSIHANDLE hRecord
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewGetColumnInfo(
        MSIHANDLE hView,
        MSICOLINFO eColumnInfo,
        MSIHANDLE* phRecord
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiViewClose(MSIHANDLE hView);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGetPrimaryKeysA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szTableName,
        MSIHANDLE* phRecord
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGetPrimaryKeysW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szTableName,
        MSIHANDLE* phRecord
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiDatabaseIsTablePersistentA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szTableName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiDatabaseIsTablePersistentW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szTableName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSummaryInformationA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szDatabasePath,
        uint uiUpdateCount,
        MSIHANDLE* phSummaryInfo
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSummaryInformationW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szDatabasePath,
        uint uiUpdateCount,
        MSIHANDLE* phSummaryInfo
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyCount(
        MSIHANDLE hSummaryInfo,
        [NativeTypeName("PUINT")] uint* puiPropertyCount
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoSetPropertyA(
        MSIHANDLE hSummaryInfo,
        uint uiProperty,
        uint uiDataType,
        int iValue,
        FILETIME* pftValue,
        [NativeTypeName("LPCSTR")] sbyte* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoSetPropertyW(
        MSIHANDLE hSummaryInfo,
        uint uiProperty,
        uint uiDataType,
        int iValue,
        FILETIME* pftValue,
        [NativeTypeName("LPCWSTR")] ushort* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyA(
        MSIHANDLE hSummaryInfo,
        uint uiProperty,
        [NativeTypeName("PUINT")] uint* puiDataType,
        [NativeTypeName("LPINT")] int* piValue,
        FILETIME* pftValue,
        [NativeTypeName("LPSTR")] sbyte* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoGetPropertyW(
        MSIHANDLE hSummaryInfo,
        uint uiProperty,
        [NativeTypeName("PUINT")] uint* puiDataType,
        [NativeTypeName("LPINT")] int* piValue,
        FILETIME* pftValue,
        [NativeTypeName("LPWSTR")] ushort* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSummaryInfoPersist(MSIHANDLE hSummaryInfo);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenDatabaseA(
        [NativeTypeName("LPCSTR")] sbyte* szDatabasePath,
        [NativeTypeName("LPCSTR")] sbyte* szPersist,
        MSIHANDLE* phDatabase
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenDatabaseW(
        [NativeTypeName("LPCWSTR")] ushort* szDatabasePath,
        [NativeTypeName("LPCWSTR")] ushort* szPersist,
        MSIHANDLE* phDatabase
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseImportA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szFolderPath,
        [NativeTypeName("LPCSTR")] sbyte* szFileName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseImportW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szFolderPath,
        [NativeTypeName("LPCWSTR")] ushort* szFileName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseExportA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szTableName,
        [NativeTypeName("LPCSTR")] sbyte* szFolderPath,
        [NativeTypeName("LPCSTR")] sbyte* szFileName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseExportW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szTableName,
        [NativeTypeName("LPCWSTR")] ushort* szFolderPath,
        [NativeTypeName("LPCWSTR")] ushort* szFileName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseMergeA(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseMerge,
        [NativeTypeName("LPCSTR")] sbyte* szTableName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseMergeW(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseMerge,
        [NativeTypeName("LPCWSTR")] ushort* szTableName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGenerateTransformA(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseReference,
        [NativeTypeName("LPCSTR")] sbyte* szTransformFile,
        int iReserved1,
        int iReserved2
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseGenerateTransformW(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseReference,
        [NativeTypeName("LPCWSTR")] ushort* szTransformFile,
        int iReserved1,
        int iReserved2
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseApplyTransformA(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCSTR")] sbyte* szTransformFile,
        int iErrorConditions
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseApplyTransformW(
        MSIHANDLE hDatabase,
        [NativeTypeName("LPCWSTR")] ushort* szTransformFile,
        int iErrorConditions
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCreateTransformSummaryInfoA(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseReference,
        [NativeTypeName("LPCSTR")] sbyte* szTransformFile,
        int iErrorConditions,
        int iValidation
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCreateTransformSummaryInfoW(
        MSIHANDLE hDatabase,
        MSIHANDLE hDatabaseReference,
        [NativeTypeName("LPCWSTR")] ushort* szTransformFile,
        int iErrorConditions,
        int iValidation
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDatabaseCommit(MSIHANDLE hDatabase);

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIDBSTATE MsiGetDatabaseState(MSIHANDLE hDatabase);

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIHANDLE MsiCreateRecord(uint cParams);

    [DllImport("msi", ExactSpelling = true)]
    public static extern BOOL MsiRecordIsNull(MSIHANDLE hRecord, uint iField);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordDataSize(MSIHANDLE hRecord, uint iField);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetInteger(MSIHANDLE hRecord, uint iField, int iValue);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStringA(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPCSTR")] sbyte* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStringW(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPCWSTR")] ushort* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern int MsiRecordGetInteger(MSIHANDLE hRecord, uint iField);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetStringA(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPSTR")] sbyte* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetStringW(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPWSTR")] ushort* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordGetFieldCount(MSIHANDLE hRecord);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStreamA(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPCSTR")] sbyte* szFilePath
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordSetStreamW(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("LPCWSTR")] ushort* szFilePath
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordReadStream(
        MSIHANDLE hRecord,
        uint iField,
        [NativeTypeName("char *")] sbyte* szDataBuf,
        [NativeTypeName("LPDWORD")] uint* pcbDataBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRecordClearData(MSIHANDLE hRecord);

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSIHANDLE MsiGetActiveDatabase(MSIHANDLE hInstall);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetPropertyA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szName,
        [NativeTypeName("LPCSTR")] sbyte* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetPropertyW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szName,
        [NativeTypeName("LPCWSTR")] ushort* szValue
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPropertyA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szName,
        [NativeTypeName("LPSTR")] sbyte* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPropertyW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szName,
        [NativeTypeName("LPWSTR")] ushort* szValueBuf,
        [NativeTypeName("LPDWORD")] uint* pcchValueBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    [return: NativeTypeName("LANGID")]
    public static extern ushort MsiGetLanguage(MSIHANDLE hInstall);

    [DllImport("msi", ExactSpelling = true)]
    public static extern BOOL MsiGetMode(MSIHANDLE hInstall, MSIRUNMODE eRunMode);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetMode(MSIHANDLE hInstall, MSIRUNMODE eRunMode, BOOL fState);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiFormatRecordA(
        MSIHANDLE hInstall,
        MSIHANDLE hRecord,
        [NativeTypeName("LPSTR")] sbyte* szResultBuf,
        [NativeTypeName("LPDWORD")] uint* pcchResultBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiFormatRecordW(
        MSIHANDLE hInstall,
        MSIHANDLE hRecord,
        [NativeTypeName("LPWSTR")] ushort* szResultBuf,
        [NativeTypeName("LPDWORD")] uint* pcchResultBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDoActionA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDoActionW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSequenceA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szTable,
        int iSequenceMode
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSequenceW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szTable,
        int iSequenceMode
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern int MsiProcessMessage(
        MSIHANDLE hInstall,
        INSTALLMESSAGE eMessageType,
        MSIHANDLE hRecord
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiEvaluateConditionA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szCondition
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern MSICONDITION MsiEvaluateConditionW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szCondition
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureStateA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFeature,
        INSTALLSTATE* piInstalled,
        INSTALLSTATE* piAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureStateW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFeature,
        INSTALLSTATE* piInstalled,
        INSTALLSTATE* piAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureStateA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFeature,
        INSTALLSTATE iState
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureStateW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFeature,
        INSTALLSTATE iState
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureAttributesA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFeature,
        [NativeTypeName("DWORD")] uint dwAttributes
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetFeatureAttributesW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFeature,
        [NativeTypeName("DWORD")] uint dwAttributes
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetComponentStateA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szComponent,
        INSTALLSTATE* piInstalled,
        INSTALLSTATE* piAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetComponentStateW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szComponent,
        INSTALLSTATE* piInstalled,
        INSTALLSTATE* piAction
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetComponentStateA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szComponent,
        INSTALLSTATE iState
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetComponentStateW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szComponent,
        INSTALLSTATE iState
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureCostA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFeature,
        MSICOSTTREE iCostTree,
        INSTALLSTATE iState,
        [NativeTypeName("LPINT")] int* piCost
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureCostW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFeature,
        MSICOSTTREE iCostTree,
        INSTALLSTATE iState,
        [NativeTypeName("LPINT")] int* piCost
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentCostsA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szComponent,
        [NativeTypeName("DWORD")] uint dwIndex,
        INSTALLSTATE iState,
        [NativeTypeName("LPSTR")] sbyte* szDriveBuf,
        [NativeTypeName("LPDWORD")] uint* pcchDriveBuf,
        [NativeTypeName("LPINT")] int* piCost,
        [NativeTypeName("LPINT")] int* piTempCost
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentCostsW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szComponent,
        [NativeTypeName("DWORD")] uint dwIndex,
        INSTALLSTATE iState,
        [NativeTypeName("LPWSTR")] ushort* szDriveBuf,
        [NativeTypeName("LPDWORD")] uint* pcchDriveBuf,
        [NativeTypeName("LPINT")] int* piCost,
        [NativeTypeName("LPINT")] int* piTempCost
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetInstallLevel(MSIHANDLE hInstall, int iInstallLevel);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureValidStatesA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFeature,
        [NativeTypeName("LPDWORD")] uint* lpInstallStates
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureValidStatesW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFeature,
        [NativeTypeName("LPDWORD")] uint* lpInstallStates
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSourcePathA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFolder,
        [NativeTypeName("LPSTR")] sbyte* szPathBuf,
        [NativeTypeName("LPDWORD")] uint* pcchPathBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetSourcePathW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFolder,
        [NativeTypeName("LPWSTR")] ushort* szPathBuf,
        [NativeTypeName("LPDWORD")] uint* pcchPathBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetTargetPathA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFolder,
        [NativeTypeName("LPSTR")] sbyte* szPathBuf,
        [NativeTypeName("LPDWORD")] uint* pcchPathBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetTargetPathW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFolder,
        [NativeTypeName("LPWSTR")] ushort* szPathBuf,
        [NativeTypeName("LPDWORD")] uint* pcchPathBuf
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetTargetPathA(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCSTR")] sbyte* szFolder,
        [NativeTypeName("LPCSTR")] sbyte* szFolderPath
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetTargetPathW(
        MSIHANDLE hInstall,
        [NativeTypeName("LPCWSTR")] ushort* szFolder,
        [NativeTypeName("LPCWSTR")] ushort* szFolderPath
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiVerifyDiskSpace(MSIHANDLE hInstall);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnableUIPreview(MSIHANDLE hDatabase, MSIHANDLE* phPreview);

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewDialogA(
        MSIHANDLE hPreview,
        [NativeTypeName("LPCSTR")] sbyte* szDialogName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewDialogW(
        MSIHANDLE hPreview,
        [NativeTypeName("LPCWSTR")] ushort* szDialogName
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewBillboardA(
        MSIHANDLE hPreview,
        [NativeTypeName("LPCSTR")] sbyte* szControlName,
        [NativeTypeName("LPCSTR")] sbyte* szBillboard
    );

    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiPreviewBillboardW(
        MSIHANDLE hPreview,
        [NativeTypeName("LPCWSTR")] ushort* szControlName,
        [NativeTypeName("LPCWSTR")] ushort* szBillboard
    );

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
    public static delegate* <MSIHANDLE, ushort*, MSIHANDLE*, uint> MsiDatabaseOpenView =>
        &MsiDatabaseOpenViewW;

    [NativeTypeName("#define MsiViewGetError MsiViewGetErrorW")]
    public static delegate* <MSIHANDLE, ushort*, uint*, MSIDBERROR> MsiViewGetError =>
        &MsiViewGetErrorW;

    [NativeTypeName("#define MsiDatabaseGetPrimaryKeys MsiDatabaseGetPrimaryKeysW")]
    public static delegate* <MSIHANDLE, ushort*, MSIHANDLE*, uint> MsiDatabaseGetPrimaryKeys =>
        &MsiDatabaseGetPrimaryKeysW;

    [NativeTypeName("#define MsiDatabaseIsTablePersistent MsiDatabaseIsTablePersistentW")]
    public static delegate* <MSIHANDLE, ushort*, MSICONDITION> MsiDatabaseIsTablePersistent =>
        &MsiDatabaseIsTablePersistentW;

    [NativeTypeName("#define MsiGetSummaryInformation MsiGetSummaryInformationW")]
    public static delegate* <MSIHANDLE, ushort*, uint, MSIHANDLE*, uint> MsiGetSummaryInformation =>
        &MsiGetSummaryInformationW;

    [NativeTypeName("#define MsiSummaryInfoSetProperty MsiSummaryInfoSetPropertyW")]
    public static delegate* <
        MSIHANDLE,
        uint,
        uint,
        int,
        FILETIME*,
        ushort*,
        uint> MsiSummaryInfoSetProperty => &MsiSummaryInfoSetPropertyW;

    [NativeTypeName("#define MsiSummaryInfoGetProperty MsiSummaryInfoGetPropertyW")]
    public static delegate* <
        MSIHANDLE,
        uint,
        uint*,
        int*,
        FILETIME*,
        ushort*,
        uint*,
        uint> MsiSummaryInfoGetProperty => &MsiSummaryInfoGetPropertyW;

    [NativeTypeName("#define MsiOpenDatabase MsiOpenDatabaseW")]
    public static delegate* <ushort*, ushort*, MSIHANDLE*, uint> MsiOpenDatabase =>
        &MsiOpenDatabaseW;

    [NativeTypeName("#define MsiDatabaseImport MsiDatabaseImportW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint> MsiDatabaseImport =>
        &MsiDatabaseImportW;

    [NativeTypeName("#define MsiDatabaseExport MsiDatabaseExportW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, ushort*, uint> MsiDatabaseExport =>
        &MsiDatabaseExportW;

    [NativeTypeName("#define MsiDatabaseMerge MsiDatabaseMergeW")]
    public static delegate* <MSIHANDLE, MSIHANDLE, ushort*, uint> MsiDatabaseMerge =>
        &MsiDatabaseMergeW;

    [NativeTypeName("#define MsiDatabaseGenerateTransform MsiDatabaseGenerateTransformW")]
    public static delegate* <
        MSIHANDLE,
        MSIHANDLE,
        ushort*,
        int,
        int,
        uint> MsiDatabaseGenerateTransform => &MsiDatabaseGenerateTransformW;

    [NativeTypeName("#define MsiDatabaseApplyTransform MsiDatabaseApplyTransformW")]
    public static delegate* <MSIHANDLE, ushort*, int, uint> MsiDatabaseApplyTransform =>
        &MsiDatabaseApplyTransformW;

    [NativeTypeName("#define MsiCreateTransformSummaryInfo MsiCreateTransformSummaryInfoW")]
    public static delegate* <
        MSIHANDLE,
        MSIHANDLE,
        ushort*,
        int,
        int,
        uint> MsiCreateTransformSummaryInfo => &MsiCreateTransformSummaryInfoW;

    [NativeTypeName("#define MsiRecordSetString MsiRecordSetStringW")]
    public static delegate* <MSIHANDLE, uint, ushort*, uint> MsiRecordSetString =>
        &MsiRecordSetStringW;

    [NativeTypeName("#define MsiRecordGetString MsiRecordGetStringW")]
    public static delegate* <MSIHANDLE, uint, ushort*, uint*, uint> MsiRecordGetString =>
        &MsiRecordGetStringW;

    [NativeTypeName("#define MsiRecordSetStream MsiRecordSetStreamW")]
    public static delegate* <MSIHANDLE, uint, ushort*, uint> MsiRecordSetStream =>
        &MsiRecordSetStreamW;

    [NativeTypeName("#define MsiSetProperty MsiSetPropertyW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint> MsiSetProperty => &MsiSetPropertyW;

    [NativeTypeName("#define MsiGetProperty MsiGetPropertyW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetProperty =>
        &MsiGetPropertyW;

    [NativeTypeName("#define MsiFormatRecord MsiFormatRecordW")]
    public static delegate* <MSIHANDLE, MSIHANDLE, ushort*, uint*, uint> MsiFormatRecord =>
        &MsiFormatRecordW;

    [NativeTypeName("#define MsiDoAction MsiDoActionW")]
    public static delegate* <MSIHANDLE, ushort*, uint> MsiDoAction => &MsiDoActionW;

    [NativeTypeName("#define MsiSequence MsiSequenceW")]
    public static delegate* <MSIHANDLE, ushort*, int, uint> MsiSequence => &MsiSequenceW;

    [NativeTypeName("#define MsiEvaluateCondition MsiEvaluateConditionW")]
    public static delegate* <MSIHANDLE, ushort*, MSICONDITION> MsiEvaluateCondition =>
        &MsiEvaluateConditionW;

    [NativeTypeName("#define MsiGetFeatureState MsiGetFeatureStateW")]
    public static delegate* <
        MSIHANDLE,
        ushort*,
        INSTALLSTATE*,
        INSTALLSTATE*,
        uint> MsiGetFeatureState => &MsiGetFeatureStateW;

    [NativeTypeName("#define MsiSetFeatureState MsiSetFeatureStateW")]
    public static delegate* <MSIHANDLE, ushort*, INSTALLSTATE, uint> MsiSetFeatureState =>
        &MsiSetFeatureStateW;

    [NativeTypeName("#define MsiSetFeatureAttributes MsiSetFeatureAttributesW")]
    public static delegate* <MSIHANDLE, ushort*, uint, uint> MsiSetFeatureAttributes =>
        &MsiSetFeatureAttributesW;

    [NativeTypeName("#define MsiGetComponentState MsiGetComponentStateW")]
    public static delegate* <
        MSIHANDLE,
        ushort*,
        INSTALLSTATE*,
        INSTALLSTATE*,
        uint> MsiGetComponentState => &MsiGetComponentStateW;

    [NativeTypeName("#define MsiSetComponentState MsiSetComponentStateW")]
    public static delegate* <MSIHANDLE, ushort*, INSTALLSTATE, uint> MsiSetComponentState =>
        &MsiSetComponentStateW;

    [NativeTypeName("#define MsiGetFeatureCost MsiGetFeatureCostW")]
    public static delegate* <
        MSIHANDLE,
        ushort*,
        MSICOSTTREE,
        INSTALLSTATE,
        int*,
        uint> MsiGetFeatureCost => &MsiGetFeatureCostW;

    [NativeTypeName("#define MsiEnumComponentCosts MsiEnumComponentCostsW")]
    public static delegate* <
        MSIHANDLE,
        ushort*,
        uint,
        INSTALLSTATE,
        ushort*,
        uint*,
        int*,
        int*,
        uint> MsiEnumComponentCosts => &MsiEnumComponentCostsW;

    [NativeTypeName("#define MsiGetFeatureValidStates MsiGetFeatureValidStatesW")]
    public static delegate* <MSIHANDLE, ushort*, uint*, uint> MsiGetFeatureValidStates =>
        &MsiGetFeatureValidStatesW;

    [NativeTypeName("#define MsiGetSourcePath MsiGetSourcePathW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetSourcePath =>
        &MsiGetSourcePathW;

    [NativeTypeName("#define MsiGetTargetPath MsiGetTargetPathW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetTargetPath =>
        &MsiGetTargetPathW;

    [NativeTypeName("#define MsiSetTargetPath MsiSetTargetPathW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint> MsiSetTargetPath =>
        &MsiSetTargetPathW;

    [NativeTypeName("#define MsiPreviewDialog MsiPreviewDialogW")]
    public static delegate* <MSIHANDLE, ushort*, uint> MsiPreviewDialog => &MsiPreviewDialogW;

    [NativeTypeName("#define MsiPreviewBillboard MsiPreviewBillboardW")]
    public static delegate* <MSIHANDLE, ushort*, ushort*, uint> MsiPreviewBillboard =>
        &MsiPreviewBillboardW;
}
