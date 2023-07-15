// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCloseHandle"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCloseHandle(MSIHANDLE hAny);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCloseAllHandles"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCloseAllHandles();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetInternalUI"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLUILEVEL MsiSetInternalUI(INSTALLUILEVEL dwUILevel, HWND* phWnd);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetExternalUIA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    [return: NativeTypeName("INSTALLUI_HANDLERA")]
    public static extern delegate* unmanaged<void*, uint, sbyte*, int> MsiSetExternalUIA([NativeTypeName("INSTALLUI_HANDLERA")] delegate* unmanaged<void*, uint, sbyte*, int> puiHandler, [NativeTypeName("DWORD")] uint dwMessageFilter, [NativeTypeName("LPVOID")] void* pvContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetExternalUIW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    [return: NativeTypeName("INSTALLUI_HANDLERW")]
    public static extern delegate* unmanaged<void*, uint, ushort*, int> MsiSetExternalUIW([NativeTypeName("INSTALLUI_HANDLERW")] delegate* unmanaged<void*, uint, ushort*, int> puiHandler, [NativeTypeName("DWORD")] uint dwMessageFilter, [NativeTypeName("LPVOID")] void* pvContext);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSetExternalUIRecord"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSetExternalUIRecord([NativeTypeName("INSTALLUI_HANDLER_RECORD")] delegate* unmanaged<void*, uint, MSIHANDLE, int> puiHandler, [NativeTypeName("DWORD")] uint dwMessageFilter, [NativeTypeName("LPVOID")] void* pvContext, [NativeTypeName("PINSTALLUI_HANDLER_RECORD")] delegate* unmanaged<void*, uint, MSIHANDLE, int> * ppuiPrevHandler);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnableLogA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnableLogA([NativeTypeName("DWORD")] uint dwLogMode, [NativeTypeName("LPCSTR")] sbyte* szLogFile, [NativeTypeName("DWORD")] uint dwLogAttributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnableLogW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnableLogW([NativeTypeName("DWORD")] uint dwLogMode, [NativeTypeName("LPCWSTR")] ushort* szLogFile, [NativeTypeName("DWORD")] uint dwLogAttributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryProductStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiQueryProductStateA([NativeTypeName("LPCSTR")] sbyte* szProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryProductStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiQueryProductStateW([NativeTypeName("LPCWSTR")] ushort* szProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szAttribute, [NativeTypeName("LPSTR")] sbyte* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szAttribute, [NativeTypeName("LPWSTR")] ushort* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoExA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCSTR")] sbyte* szProperty, [NativeTypeName("LPSTR")] sbyte* szValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoExW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCWSTR")] ushort* szProperty, [NativeTypeName("LPWSTR")] ushort* szValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallProductA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallProductA([NativeTypeName("LPCSTR")] sbyte* szPackagePath, [NativeTypeName("LPCSTR")] sbyte* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallProductW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallProductW([NativeTypeName("LPCWSTR")] ushort* szPackagePath, [NativeTypeName("LPCWSTR")] ushort* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureProductA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureProductA([NativeTypeName("LPCSTR")] sbyte* szProduct, int iInstallLevel, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureProductW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureProductW([NativeTypeName("LPCWSTR")] ushort* szProduct, int iInstallLevel, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureProductExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureProductExA([NativeTypeName("LPCSTR")] sbyte* szProduct, int iInstallLevel, INSTALLSTATE eInstallState, [NativeTypeName("LPCSTR")] sbyte* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureProductExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureProductExW([NativeTypeName("LPCWSTR")] ushort* szProduct, int iInstallLevel, INSTALLSTATE eInstallState, [NativeTypeName("LPCWSTR")] ushort* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiReinstallProductA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiReinstallProductA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("DWORD")] uint szReinstallMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiReinstallProductW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiReinstallProductW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("DWORD")] uint szReinstallMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseProductExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseProductExA([NativeTypeName("LPCSTR")] sbyte* szPackagePath, [NativeTypeName("LPCSTR")] sbyte* szScriptfilePath, [NativeTypeName("LPCSTR")] sbyte* szTransforms, [NativeTypeName("LANGID")] ushort lgidLanguage, [NativeTypeName("DWORD")] uint dwPlatform, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseProductExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseProductExW([NativeTypeName("LPCWSTR")] ushort* szPackagePath, [NativeTypeName("LPCWSTR")] ushort* szScriptfilePath, [NativeTypeName("LPCWSTR")] ushort* szTransforms, [NativeTypeName("LANGID")] ushort lgidLanguage, [NativeTypeName("DWORD")] uint dwPlatform, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseProductA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseProductA([NativeTypeName("LPCSTR")] sbyte* szPackagePath, [NativeTypeName("LPCSTR")] sbyte* szScriptfilePath, [NativeTypeName("LPCSTR")] sbyte* szTransforms, [NativeTypeName("LANGID")] ushort lgidLanguage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseProductW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseProductW([NativeTypeName("LPCWSTR")] ushort* szPackagePath, [NativeTypeName("LPCWSTR")] ushort* szScriptfilePath, [NativeTypeName("LPCWSTR")] ushort* szTransforms, [NativeTypeName("LANGID")] ushort lgidLanguage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProcessAdvertiseScriptA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProcessAdvertiseScriptA([NativeTypeName("LPCSTR")] sbyte* szScriptFile, [NativeTypeName("LPCSTR")] sbyte* szIconFolder, HKEY hRegData, BOOL fShortcuts, BOOL fRemoveItems);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProcessAdvertiseScriptW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProcessAdvertiseScriptW([NativeTypeName("LPCWSTR")] ushort* szScriptFile, [NativeTypeName("LPCWSTR")] ushort* szIconFolder, HKEY hRegData, BOOL fShortcuts, BOOL fRemoveItems);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseScriptA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseScriptA([NativeTypeName("LPCSTR")] sbyte* szScriptFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PHKEY")] HKEY* phRegData, BOOL fRemoveItems);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiAdvertiseScriptW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiAdvertiseScriptW([NativeTypeName("LPCWSTR")] ushort* szScriptFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PHKEY")] HKEY* phRegData, BOOL fRemoveItems);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoFromScriptA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoFromScriptA([NativeTypeName("LPCSTR")] sbyte* szScriptFile, [NativeTypeName("LPSTR")] sbyte* lpProductBuf39, [NativeTypeName("LANGID *")] ushort* plgidLanguage, [NativeTypeName("LPDWORD")] uint* pdwVersion, [NativeTypeName("LPSTR")] sbyte* lpNameBuf, [NativeTypeName("LPDWORD")] uint* pcchNameBuf, [NativeTypeName("LPSTR")] sbyte* lpPackageBuf, [NativeTypeName("LPDWORD")] uint* pcchPackageBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductInfoFromScriptW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductInfoFromScriptW([NativeTypeName("LPCWSTR")] ushort* szScriptFile, [NativeTypeName("LPWSTR")] ushort* lpProductBuf39, [NativeTypeName("LANGID *")] ushort* plgidLanguage, [NativeTypeName("LPDWORD")] uint* pdwVersion, [NativeTypeName("LPWSTR")] ushort* lpNameBuf, [NativeTypeName("LPDWORD")] uint* pcchNameBuf, [NativeTypeName("LPWSTR")] ushort* lpPackageBuf, [NativeTypeName("LPDWORD")] uint* pcchPackageBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductCodeA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductCodeA([NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("LPSTR")] sbyte* lpBuf39);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductCodeW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductCodeW([NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("LPWSTR")] ushort* lpBuf39);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetUserInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern USERINFOSTATE MsiGetUserInfoA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPSTR")] sbyte* lpUserNameBuf, [NativeTypeName("LPDWORD")] uint* pcchUserNameBuf, [NativeTypeName("LPSTR")] sbyte* lpOrgNameBuf, [NativeTypeName("LPDWORD")] uint* pcchOrgNameBuf, [NativeTypeName("LPSTR")] sbyte* lpSerialBuf, [NativeTypeName("LPDWORD")] uint* pcchSerialBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetUserInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern USERINFOSTATE MsiGetUserInfoW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPWSTR")] ushort* lpUserNameBuf, [NativeTypeName("LPDWORD")] uint* pcchUserNameBuf, [NativeTypeName("LPWSTR")] ushort* lpOrgNameBuf, [NativeTypeName("LPDWORD")] uint* pcchOrgNameBuf, [NativeTypeName("LPWSTR")] ushort* lpSerialBuf, [NativeTypeName("LPDWORD")] uint* pcchSerialBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCollectUserInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCollectUserInfoA([NativeTypeName("LPCSTR")] sbyte* szProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiCollectUserInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiCollectUserInfoW([NativeTypeName("LPCWSTR")] ushort* szProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiApplyPatchA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiApplyPatchA([NativeTypeName("LPCSTR")] sbyte* szPatchPackage, [NativeTypeName("LPCSTR")] sbyte* szInstallPackage, INSTALLTYPE eInstallType, [NativeTypeName("LPCSTR")] sbyte* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiApplyPatchW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiApplyPatchW([NativeTypeName("LPCWSTR")] ushort* szPatchPackage, [NativeTypeName("LPCWSTR")] ushort* szInstallPackage, INSTALLTYPE eInstallType, [NativeTypeName("LPCWSTR")] ushort* szCommandLine);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchInfoA([NativeTypeName("LPCSTR")] sbyte* szPatch, [NativeTypeName("LPCSTR")] sbyte* szAttribute, [NativeTypeName("LPSTR")] sbyte* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchInfoW([NativeTypeName("LPCWSTR")] ushort* szPatch, [NativeTypeName("LPCWSTR")] ushort* szAttribute, [NativeTypeName("LPWSTR")] ushort* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumPatchesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumPatchesA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("DWORD")] uint iPatchIndex, [NativeTypeName("LPSTR")] sbyte* lpPatchBuf, [NativeTypeName("LPSTR")] sbyte* lpTransformsBuf, [NativeTypeName("LPDWORD")] uint* pcchTransformsBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumPatchesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumPatchesW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("DWORD")] uint iPatchIndex, [NativeTypeName("LPWSTR")] ushort* lpPatchBuf, [NativeTypeName("LPWSTR")] ushort* lpTransformsBuf, [NativeTypeName("LPDWORD")] uint* pcchTransformsBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRemovePatchesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRemovePatchesA([NativeTypeName("LPCSTR")] sbyte* szPatchList, [NativeTypeName("LPCSTR")] sbyte* szProductCode, INSTALLTYPE eUninstallType, [NativeTypeName("LPCSTR")] sbyte* szPropertyList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiRemovePatchesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiRemovePatchesW([NativeTypeName("LPCWSTR")] ushort* szPatchList, [NativeTypeName("LPCWSTR")] ushort* szProductCode, INSTALLTYPE eUninstallType, [NativeTypeName("LPCWSTR")] ushort* szPropertyList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiExtractPatchXMLDataA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiExtractPatchXMLDataA([NativeTypeName("LPCSTR")] sbyte* szPatchPath, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPSTR")] sbyte* szXMLData, [NativeTypeName("LPDWORD")] uint* pcchXMLData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiExtractPatchXMLDataW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiExtractPatchXMLDataW([NativeTypeName("LPCWSTR")] ushort* szPatchPath, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR")] ushort* szXMLData, [NativeTypeName("LPDWORD")] uint* pcchXMLData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchInfoExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchInfoExA([NativeTypeName("LPCSTR")] sbyte* szPatchCode, [NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCSTR")] sbyte* szProperty, [NativeTypeName("LPSTR")] sbyte* lpValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchInfoExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchInfoExW([NativeTypeName("LPCWSTR")] ushort* szPatchCode, [NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCWSTR")] ushort* szProperty, [NativeTypeName("LPWSTR")] ushort* lpValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiApplyMultiplePatchesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiApplyMultiplePatchesA([NativeTypeName("LPCSTR")] sbyte* szPatchPackages, [NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szPropertiesList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiApplyMultiplePatchesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiApplyMultiplePatchesW([NativeTypeName("LPCWSTR")] ushort* szPatchPackages, [NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szPropertiesList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDeterminePatchSequenceA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDeterminePatchSequenceA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint cPatchInfo, [NativeTypeName("PMSIPATCHSEQUENCEINFOA")] MSIPATCHSEQUENCEINFOA* pPatchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDeterminePatchSequenceW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDeterminePatchSequenceW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint cPatchInfo, [NativeTypeName("PMSIPATCHSEQUENCEINFOW")] MSIPATCHSEQUENCEINFOW* pPatchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDetermineApplicablePatchesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDetermineApplicablePatchesA([NativeTypeName("LPCSTR")] sbyte* szProductPackagePath, [NativeTypeName("DWORD")] uint cPatchInfo, [NativeTypeName("PMSIPATCHSEQUENCEINFOA")] MSIPATCHSEQUENCEINFOA* pPatchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiDetermineApplicablePatchesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiDetermineApplicablePatchesW([NativeTypeName("LPCWSTR")] ushort* szProductPackagePath, [NativeTypeName("DWORD")] uint cPatchInfo, [NativeTypeName("PMSIPATCHSEQUENCEINFOW")] MSIPATCHSEQUENCEINFOW* pPatchInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumPatchesExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumPatchesExA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwFilter, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("CHAR[39]")] sbyte* szPatchCode, [NativeTypeName("CHAR[39]")] sbyte* szTargetProductCode, MSIINSTALLCONTEXT* pdwTargetProductContext, [NativeTypeName("LPSTR")] sbyte* szTargetUserSid, [NativeTypeName("LPDWORD")] uint* pcchTargetUserSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumPatchesExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumPatchesExW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwFilter, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("WCHAR[39]")] ushort* szPatchCode, [NativeTypeName("WCHAR[39]")] ushort* szTargetProductCode, MSIINSTALLCONTEXT* pdwTargetProductContext, [NativeTypeName("LPWSTR")] ushort* szTargetUserSid, [NativeTypeName("LPDWORD")] uint* pcchTargetUserSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryFeatureStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiQueryFeatureStateA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryFeatureStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiQueryFeatureStateW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryFeatureStateExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiQueryFeatureStateExA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE* pdwState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryFeatureStateExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiQueryFeatureStateExW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE* pdwState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiUseFeatureA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiUseFeatureA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiUseFeatureW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiUseFeatureW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiUseFeatureExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiUseFeatureExA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiUseFeatureExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiUseFeatureExW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureUsageA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureUsageA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("LPDWORD")] uint* pdwUseCount, [NativeTypeName("LPWORD")] ushort* pwDateUsed);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureUsageW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureUsageW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("LPDWORD")] uint* pdwUseCount, [NativeTypeName("LPWORD")] ushort* pwDateUsed);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureFeatureA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureFeatureA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiConfigureFeatureW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiConfigureFeatureW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiReinstallFeatureA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiReinstallFeatureA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("DWORD")] uint dwReinstallMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiReinstallFeatureW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiReinstallFeatureW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("DWORD")] uint dwReinstallMode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideComponentA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideComponentA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideComponentW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideComponentW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideQualifiedComponentA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideQualifiedComponentA([NativeTypeName("LPCSTR")] sbyte* szCategory, [NativeTypeName("LPCSTR")] sbyte* szQualifier, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideQualifiedComponentW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideQualifiedComponentW([NativeTypeName("LPCWSTR")] ushort* szCategory, [NativeTypeName("LPCWSTR")] ushort* szQualifier, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideQualifiedComponentExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideQualifiedComponentExA([NativeTypeName("LPCSTR")] sbyte* szCategory, [NativeTypeName("LPCSTR")] sbyte* szQualifier, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("DWORD")] uint dwUnused1, [NativeTypeName("DWORD")] uint dwUnused2, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideQualifiedComponentExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideQualifiedComponentExW([NativeTypeName("LPCWSTR")] ushort* szCategory, [NativeTypeName("LPCWSTR")] ushort* szQualifier, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("DWORD")] uint dwUnused1, [NativeTypeName("DWORD")] uint dwUnused2, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentPathA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiGetComponentPathA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentPathW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiGetComponentPathW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentPathExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiGetComponentPathExA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szComponentCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPSTR")] sbyte* lpOutPathBuffer, [NativeTypeName("LPDWORD")] uint* pcchOutPathBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetComponentPathExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiGetComponentPathExW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szComponentCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPWSTR")] ushort* lpOutPathBuffer, [NativeTypeName("LPDWORD")] uint* pcchOutPathBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideAssemblyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideAssemblyA([NativeTypeName("LPCSTR")] sbyte* szAssemblyName, [NativeTypeName("LPCSTR")] sbyte* szAppContext, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("DWORD")] uint dwAssemblyInfo, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiProvideAssemblyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiProvideAssemblyW([NativeTypeName("LPCWSTR")] ushort* szAssemblyName, [NativeTypeName("LPCWSTR")] ushort* szAppContext, [NativeTypeName("DWORD")] uint dwInstallMode, [NativeTypeName("DWORD")] uint dwAssemblyInfo, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchPathBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryComponentStateA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiQueryComponentStateA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCSTR")] sbyte* szComponentCode, INSTALLSTATE* pdwState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiQueryComponentStateW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiQueryComponentStateW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("LPCWSTR")] ushort* szComponentCode, INSTALLSTATE* pdwState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumProductsA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumProductsA([NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPSTR")] sbyte* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumProductsW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumProductsW([NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPWSTR")] ushort* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumProductsExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumProductsExA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("CHAR[39]")] sbyte* szInstalledProductCode, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPSTR")] sbyte* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumProductsExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumProductsExW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("WCHAR[39]")] ushort* szInstalledProductCode, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPWSTR")] ushort* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumRelatedProductsA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumRelatedProductsA([NativeTypeName("LPCSTR")] sbyte* lpUpgradeCode, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPSTR")] sbyte* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumRelatedProductsW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumRelatedProductsW([NativeTypeName("LPCWSTR")] ushort* lpUpgradeCode, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPWSTR")] ushort* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumFeaturesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumFeaturesA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("DWORD")] uint iFeatureIndex, [NativeTypeName("LPSTR")] sbyte* lpFeatureBuf, [NativeTypeName("LPSTR")] sbyte* lpParentBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumFeaturesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumFeaturesW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("DWORD")] uint iFeatureIndex, [NativeTypeName("LPWSTR")] ushort* lpFeatureBuf, [NativeTypeName("LPWSTR")] ushort* lpParentBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentsA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentsA([NativeTypeName("DWORD")] uint iComponentIndex, [NativeTypeName("LPSTR")] sbyte* lpComponentBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentsW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentsW([NativeTypeName("DWORD")] uint iComponentIndex, [NativeTypeName("LPWSTR")] ushort* lpComponentBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentsExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentsExA([NativeTypeName("LPCSTR")] sbyte* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("CHAR[39]")] sbyte* szInstalledComponentCode, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPSTR")] sbyte* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentsExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentsExW([NativeTypeName("LPCWSTR")] ushort* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("WCHAR[39]")] ushort* szInstalledComponentCode, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPWSTR")] ushort* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumClientsA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumClientsA([NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPSTR")] sbyte* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumClientsW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumClientsW([NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("DWORD")] uint iProductIndex, [NativeTypeName("LPWSTR")] ushort* lpProductBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumClientsExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumClientsExA([NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("LPCSTR")] sbyte* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwProductIndex, [NativeTypeName("CHAR[39]")] sbyte* szProductBuf, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPSTR")] sbyte* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumClientsExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumClientsExW([NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("LPCWSTR")] ushort* szUserSid, [NativeTypeName("DWORD")] uint dwContext, [NativeTypeName("DWORD")] uint dwProductIndex, [NativeTypeName("WCHAR[39]")] ushort* szProductBuf, MSIINSTALLCONTEXT* pdwInstalledContext, [NativeTypeName("LPWSTR")] ushort* szSid, [NativeTypeName("LPDWORD")] uint* pcchSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentQualifiersA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentQualifiersA([NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("DWORD")] uint iIndex, [NativeTypeName("LPSTR")] sbyte* lpQualifierBuf, [NativeTypeName("LPDWORD")] uint* pcchQualifierBuf, [NativeTypeName("LPSTR")] sbyte* lpApplicationDataBuf, [NativeTypeName("LPDWORD")] uint* pcchApplicationDataBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEnumComponentQualifiersW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEnumComponentQualifiersW([NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("DWORD")] uint iIndex, [NativeTypeName("LPWSTR")] ushort* lpQualifierBuf, [NativeTypeName("LPDWORD")] uint* pcchQualifierBuf, [NativeTypeName("LPWSTR")] ushort* lpApplicationDataBuf, [NativeTypeName("LPDWORD")] uint* pcchApplicationDataBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenProductA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenProductA([NativeTypeName("LPCSTR")] sbyte* szProduct, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenProductW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenProductW([NativeTypeName("LPCWSTR")] ushort* szProduct, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenPackageA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenPackageA([NativeTypeName("LPCSTR")] sbyte* szPackagePath, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenPackageW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenPackageW([NativeTypeName("LPCWSTR")] ushort* szPackagePath, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenPackageExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenPackageExA([NativeTypeName("LPCSTR")] sbyte* szPackagePath, [NativeTypeName("DWORD")] uint dwOptions, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiOpenPackageExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiOpenPackageExW([NativeTypeName("LPCWSTR")] ushort* szPackagePath, [NativeTypeName("DWORD")] uint dwOptions, MSIHANDLE* hProduct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchFileListA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchFileListA([NativeTypeName("LPCSTR")] sbyte* szProductCode, [NativeTypeName("LPCSTR")] sbyte* szPatchPackages, [NativeTypeName("LPDWORD")] uint* pcFiles, MSIHANDLE** pphFileRecords);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetPatchFileListW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetPatchFileListW([NativeTypeName("LPCWSTR")] ushort* szProductCode, [NativeTypeName("LPCWSTR")] ushort* szPatchPackages, [NativeTypeName("LPDWORD")] uint* pcFiles, MSIHANDLE** pphFileRecords);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductPropertyA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductPropertyA(MSIHANDLE hProduct, [NativeTypeName("LPCSTR")] sbyte* szProperty, [NativeTypeName("LPSTR")] sbyte* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetProductPropertyW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetProductPropertyW(MSIHANDLE hProduct, [NativeTypeName("LPCWSTR")] ushort* szProperty, [NativeTypeName("LPWSTR")] ushort* lpValueBuf, [NativeTypeName("LPDWORD")] uint* pcchValueBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiVerifyPackageA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiVerifyPackageA([NativeTypeName("LPCSTR")] sbyte* szPackagePath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiVerifyPackageW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiVerifyPackageW([NativeTypeName("LPCWSTR")] ushort* szPackagePath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureInfoA(MSIHANDLE hProduct, [NativeTypeName("LPCSTR")] sbyte* szFeature, [NativeTypeName("LPDWORD")] uint* lpAttributes, [NativeTypeName("LPSTR")] sbyte* lpTitleBuf, [NativeTypeName("LPDWORD")] uint* pcchTitleBuf, [NativeTypeName("LPSTR")] sbyte* lpHelpBuf, [NativeTypeName("LPDWORD")] uint* pcchHelpBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFeatureInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFeatureInfoW(MSIHANDLE hProduct, [NativeTypeName("LPCWSTR")] ushort* szFeature, [NativeTypeName("LPDWORD")] uint* lpAttributes, [NativeTypeName("LPWSTR")] ushort* lpTitleBuf, [NativeTypeName("LPDWORD")] uint* pcchTitleBuf, [NativeTypeName("LPWSTR")] ushort* lpHelpBuf, [NativeTypeName("LPDWORD")] uint* pcchHelpBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallMissingComponentA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallMissingComponentA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szComponent, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallMissingComponentW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallMissingComponentW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szComponent, INSTALLSTATE eInstallState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallMissingFileA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallMissingFileA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiInstallMissingFileW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiInstallMissingFileW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szFile);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiLocateComponentA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiLocateComponentA([NativeTypeName("LPCSTR")] sbyte* szComponent, [NativeTypeName("LPSTR")] sbyte* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiLocateComponentW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern INSTALLSTATE MsiLocateComponentW([NativeTypeName("LPCWSTR")] ushort* szComponent, [NativeTypeName("LPWSTR")] ushort* lpPathBuf, [NativeTypeName("LPDWORD")] uint* pcchBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearAllA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearAllA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szUserName, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearAllW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearAllW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szUserName, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddSourceA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddSourceA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szUserName, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPCSTR")] sbyte* szSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddSourceW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddSourceW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szUserName, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPCWSTR")] ushort* szSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListForceResolutionA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListForceResolutionA([NativeTypeName("LPCSTR")] sbyte* szProduct, [NativeTypeName("LPCSTR")] sbyte* szUserName, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListForceResolutionW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListForceResolutionW([NativeTypeName("LPCWSTR")] ushort* szProduct, [NativeTypeName("LPCWSTR")] ushort* szUserName, [NativeTypeName("DWORD")] uint dwReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddSourceExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddSourceExA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCSTR")] sbyte* szSource, [NativeTypeName("DWORD")] uint dwIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddSourceExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddSourceExW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* szSource, [NativeTypeName("DWORD")] uint dwIndex);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddMediaDiskA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddMediaDiskA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwDiskId, [NativeTypeName("LPCSTR")] sbyte* szVolumeLabel, [NativeTypeName("LPCSTR")] sbyte* szDiskPrompt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListAddMediaDiskW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListAddMediaDiskW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwDiskId, [NativeTypeName("LPCWSTR")] ushort* szVolumeLabel, [NativeTypeName("LPCWSTR")] ushort* szDiskPrompt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearSourceA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearSourceA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCSTR")] sbyte* szSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearSourceW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearSourceW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* szSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearMediaDiskA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearMediaDiskA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwDiskId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearMediaDiskW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearMediaDiskW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwDiskId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearAllExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearAllExA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListClearAllExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListClearAllExW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListForceResolutionExA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListForceResolutionExA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListForceResolutionExW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListForceResolutionExW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListSetInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListSetInfoA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCSTR")] sbyte* szProperty, [NativeTypeName("LPCSTR")] sbyte* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListSetInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListSetInfoW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* szProperty, [NativeTypeName("LPCWSTR")] ushort* szValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListGetInfoA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListGetInfoA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCSTR")] sbyte* szProperty, [NativeTypeName("LPSTR")] sbyte* szValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListGetInfoW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListGetInfoW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("LPCWSTR")] ushort* szProperty, [NativeTypeName("LPWSTR")] ushort* szValue, [NativeTypeName("LPDWORD")] uint* pcchValue);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListEnumSourcesA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListEnumSourcesA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* szSource, [NativeTypeName("LPDWORD")] uint* pcchSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListEnumSourcesW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListEnumSourcesW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* szSource, [NativeTypeName("LPDWORD")] uint* pcchSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListEnumMediaDisksA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListEnumMediaDisksA([NativeTypeName("LPCSTR")] sbyte* szProductCodeOrPatchCode, [NativeTypeName("LPCSTR")] sbyte* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPDWORD")] uint* pdwDiskId, [NativeTypeName("LPSTR")] sbyte* szVolumeLabel, [NativeTypeName("LPDWORD")] uint* pcchVolumeLabel, [NativeTypeName("LPSTR")] sbyte* szDiskPrompt, [NativeTypeName("LPDWORD")] uint* pcchDiskPrompt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiSourceListEnumMediaDisksW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiSourceListEnumMediaDisksW([NativeTypeName("LPCWSTR")] ushort* szProductCodeOrPatchCode, [NativeTypeName("LPCWSTR")] ushort* szUserSid, MSIINSTALLCONTEXT dwContext, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPDWORD")] uint* pdwDiskId, [NativeTypeName("LPWSTR")] ushort* szVolumeLabel, [NativeTypeName("LPDWORD")] uint* pcchVolumeLabel, [NativeTypeName("LPWSTR")] ushort* szDiskPrompt, [NativeTypeName("LPDWORD")] uint* pcchDiskPrompt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileVersionA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFileVersionA([NativeTypeName("LPCSTR")] sbyte* szFilePath, [NativeTypeName("LPSTR")] sbyte* lpVersionBuf, [NativeTypeName("LPDWORD")] uint* pcchVersionBuf, [NativeTypeName("LPSTR")] sbyte* lpLangBuf, [NativeTypeName("LPDWORD")] uint* pcchLangBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileVersionW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFileVersionW([NativeTypeName("LPCWSTR")] ushort* szFilePath, [NativeTypeName("LPWSTR")] ushort* lpVersionBuf, [NativeTypeName("LPDWORD")] uint* pcchVersionBuf, [NativeTypeName("LPWSTR")] ushort* lpLangBuf, [NativeTypeName("LPDWORD")] uint* pcchLangBuf);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileHashA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFileHashA([NativeTypeName("LPCSTR")] sbyte* szFilePath, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("PMSIFILEHASHINFO")] MSIFILEHASHINFO* pHash);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileHashW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetFileHashW([NativeTypeName("LPCWSTR")] ushort* szFilePath, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("PMSIFILEHASHINFO")] MSIFILEHASHINFO* pHash);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileSignatureInformationA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern HRESULT MsiGetFileSignatureInformationA([NativeTypeName("LPCSTR")] sbyte* szSignedObjectPath, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppcCertContext, [NativeTypeName("LPBYTE")] byte* pbHashData, [NativeTypeName("LPDWORD")] uint* pcbHashData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetFileSignatureInformationW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern HRESULT MsiGetFileSignatureInformationW([NativeTypeName("LPCWSTR")] ushort* szSignedObjectPath, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCERT_CONTEXT *")] CERT_CONTEXT** ppcCertContext, [NativeTypeName("LPBYTE")] byte* pbHashData, [NativeTypeName("LPDWORD")] uint* pcbHashData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetShortcutTargetA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetShortcutTargetA([NativeTypeName("LPCSTR")] sbyte* szShortcutPath, [NativeTypeName("LPSTR")] sbyte* szProductCode, [NativeTypeName("LPSTR")] sbyte* szFeatureId, [NativeTypeName("LPSTR")] sbyte* szComponentCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiGetShortcutTargetW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiGetShortcutTargetW([NativeTypeName("LPCWSTR")] ushort* szShortcutPath, [NativeTypeName("LPWSTR")] ushort* szProductCode, [NativeTypeName("LPWSTR")] ushort* szFeatureId, [NativeTypeName("LPWSTR")] ushort* szComponentCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiIsProductElevatedA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiIsProductElevatedA([NativeTypeName("LPCSTR")] sbyte* szProduct, BOOL* pfElevated);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiIsProductElevatedW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiIsProductElevatedW([NativeTypeName("LPCWSTR")] ushort* szProduct, BOOL* pfElevated);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiNotifySidChangeA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiNotifySidChangeA([NativeTypeName("LPCSTR")] sbyte* pOldSid, [NativeTypeName("LPCSTR")] sbyte* pNewSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiNotifySidChangeW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiNotifySidChangeW([NativeTypeName("LPCWSTR")] ushort* pOldSid, [NativeTypeName("LPCWSTR")] ushort* pNewSid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiBeginTransactionA"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiBeginTransactionA([NativeTypeName("LPCSTR")] sbyte* szName, [NativeTypeName("DWORD")] uint dwTransactionAttributes, MSIHANDLE* phTransactionHandle, HANDLE* phChangeOfOwnerEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiBeginTransactionW"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiBeginTransactionW([NativeTypeName("LPCWSTR")] ushort* szName, [NativeTypeName("DWORD")] uint dwTransactionAttributes, MSIHANDLE* phTransactionHandle, HANDLE* phChangeOfOwnerEvent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiEndTransaction"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiEndTransaction([NativeTypeName("DWORD")] uint dwTransactionState);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MsiJoinTransaction"]/*'/>
    [DllImport("msi", ExactSpelling = true)]
    public static extern uint MsiJoinTransaction(MSIHANDLE hTransactionHandle, [NativeTypeName("DWORD")] uint dwTransactionAttributes, HANDLE* phChangeOfOwnerEvent);
    [NativeTypeName("#define MsiSetExternalUI MsiSetExternalUIW")]
    public static delegate*<delegate* unmanaged<void*, uint, ushort*, int> , uint, void*, delegate* unmanaged<void*, uint, ushort*, int> > MsiSetExternalUI => &MsiSetExternalUIW;

    [NativeTypeName("#define MsiEnableLog MsiEnableLogW")]
    public static delegate*<uint, ushort*, uint, uint> MsiEnableLog => &MsiEnableLogW;

    [NativeTypeName("#define MsiQueryProductState MsiQueryProductStateW")]
    public static delegate*<ushort*, INSTALLSTATE> MsiQueryProductState => &MsiQueryProductStateW;

    [NativeTypeName("#define MsiGetProductInfo MsiGetProductInfoW")]
    public static delegate*<ushort*, ushort*, ushort*, uint*, uint> MsiGetProductInfo => &MsiGetProductInfoW;

    [NativeTypeName("#define MsiGetProductInfoEx MsiGetProductInfoExW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, ushort*, ushort*, uint*, uint> MsiGetProductInfoEx => &MsiGetProductInfoExW;

    [NativeTypeName("#define MsiInstallProduct MsiInstallProductW")]
    public static delegate*<ushort*, ushort*, uint> MsiInstallProduct => &MsiInstallProductW;

    [NativeTypeName("#define MsiConfigureProduct MsiConfigureProductW")]
    public static delegate*<ushort*, int, INSTALLSTATE, uint> MsiConfigureProduct => &MsiConfigureProductW;

    [NativeTypeName("#define MsiConfigureProductEx MsiConfigureProductExW")]
    public static delegate*<ushort*, int, INSTALLSTATE, ushort*, uint> MsiConfigureProductEx => &MsiConfigureProductExW;

    [NativeTypeName("#define MsiReinstallProduct MsiReinstallProductW")]
    public static delegate*<ushort*, uint, uint> MsiReinstallProduct => &MsiReinstallProductW;

    [NativeTypeName("#define MsiAdvertiseProductEx MsiAdvertiseProductExW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort, uint, uint, uint> MsiAdvertiseProductEx => &MsiAdvertiseProductExW;

    [NativeTypeName("#define MsiAdvertiseProduct MsiAdvertiseProductW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort, uint> MsiAdvertiseProduct => &MsiAdvertiseProductW;

    [NativeTypeName("#define MsiProcessAdvertiseScript MsiProcessAdvertiseScriptW")]
    public static delegate*<ushort*, ushort*, HKEY, BOOL, BOOL, uint> MsiProcessAdvertiseScript => &MsiProcessAdvertiseScriptW;

    [NativeTypeName("#define MsiAdvertiseScript MsiAdvertiseScriptW")]
    public static delegate*<ushort*, uint, HKEY*, BOOL, uint> MsiAdvertiseScript => &MsiAdvertiseScriptW;

    [NativeTypeName("#define MsiGetProductInfoFromScript MsiGetProductInfoFromScriptW")]
    public static delegate*<ushort*, ushort*, ushort*, uint*, ushort*, uint*, ushort*, uint*, uint> MsiGetProductInfoFromScript => &MsiGetProductInfoFromScriptW;

    [NativeTypeName("#define MsiGetProductCode MsiGetProductCodeW")]
    public static delegate*<ushort*, ushort*, uint> MsiGetProductCode => &MsiGetProductCodeW;

    [NativeTypeName("#define MsiGetUserInfo MsiGetUserInfoW")]
    public static delegate*<ushort*, ushort*, uint*, ushort*, uint*, ushort*, uint*, USERINFOSTATE> MsiGetUserInfo => &MsiGetUserInfoW;

    [NativeTypeName("#define MsiCollectUserInfo MsiCollectUserInfoW")]
    public static delegate*<ushort*, uint> MsiCollectUserInfo => &MsiCollectUserInfoW;

    [NativeTypeName("#define MsiApplyPatch MsiApplyPatchW")]
    public static delegate*<ushort*, ushort*, INSTALLTYPE, ushort*, uint> MsiApplyPatch => &MsiApplyPatchW;

    [NativeTypeName("#define MsiGetPatchInfo MsiGetPatchInfoW")]
    public static delegate*<ushort*, ushort*, ushort*, uint*, uint> MsiGetPatchInfo => &MsiGetPatchInfoW;

    [NativeTypeName("#define MsiEnumPatches MsiEnumPatchesW")]
    public static delegate*<ushort*, uint, ushort*, ushort*, uint*, uint> MsiEnumPatches => &MsiEnumPatchesW;

    [NativeTypeName("#define MsiRemovePatches MsiRemovePatchesW")]
    public static delegate*<ushort*, ushort*, INSTALLTYPE, ushort*, uint> MsiRemovePatches => &MsiRemovePatchesW;

    [NativeTypeName("#define MsiExtractPatchXMLData MsiExtractPatchXMLDataW")]
    public static delegate*<ushort*, uint, ushort*, uint*, uint> MsiExtractPatchXMLData => &MsiExtractPatchXMLDataW;

    [NativeTypeName("#define MsiGetPatchInfoEx MsiGetPatchInfoExW")]
    public static delegate*<ushort*, ushort*, ushort*, MSIINSTALLCONTEXT, ushort*, ushort*, uint*, uint> MsiGetPatchInfoEx => &MsiGetPatchInfoExW;

    [NativeTypeName("#define MsiApplyMultiplePatches MsiApplyMultiplePatchesW")]
    public static delegate*<ushort*, ushort*, ushort*, uint> MsiApplyMultiplePatches => &MsiApplyMultiplePatchesW;

    [NativeTypeName("#define MsiDeterminePatchSequence MsiDeterminePatchSequenceW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, MSIPATCHSEQUENCEINFOW*, uint> MsiDeterminePatchSequence => &MsiDeterminePatchSequenceW;

    [NativeTypeName("#define MsiDetermineApplicablePatches MsiDetermineApplicablePatchesW")]
    public static delegate*<ushort*, uint, MSIPATCHSEQUENCEINFOW*, uint> MsiDetermineApplicablePatches => &MsiDetermineApplicablePatchesW;

    [NativeTypeName("#define MsiEnumPatchesEx MsiEnumPatchesExW")]
    public static delegate*<ushort*, ushort*, uint, uint, uint, ushort*, ushort*, MSIINSTALLCONTEXT*, ushort*, uint*, uint> MsiEnumPatchesEx => &MsiEnumPatchesExW;

    [NativeTypeName("#define MsiQueryFeatureState MsiQueryFeatureStateW")]
    public static delegate*<ushort*, ushort*, INSTALLSTATE> MsiQueryFeatureState => &MsiQueryFeatureStateW;

    [NativeTypeName("#define MsiQueryFeatureStateEx MsiQueryFeatureStateExW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, ushort*, INSTALLSTATE*, uint> MsiQueryFeatureStateEx => &MsiQueryFeatureStateExW;

    [NativeTypeName("#define MsiUseFeature MsiUseFeatureW")]
    public static delegate*<ushort*, ushort*, INSTALLSTATE> MsiUseFeature => &MsiUseFeatureW;

    [NativeTypeName("#define MsiUseFeatureEx MsiUseFeatureExW")]
    public static delegate*<ushort*, ushort*, uint, uint, INSTALLSTATE> MsiUseFeatureEx => &MsiUseFeatureExW;

    [NativeTypeName("#define MsiGetFeatureUsage MsiGetFeatureUsageW")]
    public static delegate*<ushort*, ushort*, uint*, ushort*, uint> MsiGetFeatureUsage => &MsiGetFeatureUsageW;

    [NativeTypeName("#define MsiConfigureFeature MsiConfigureFeatureW")]
    public static delegate*<ushort*, ushort*, INSTALLSTATE, uint> MsiConfigureFeature => &MsiConfigureFeatureW;

    [NativeTypeName("#define MsiReinstallFeature MsiReinstallFeatureW")]
    public static delegate*<ushort*, ushort*, uint, uint> MsiReinstallFeature => &MsiReinstallFeatureW;

    [NativeTypeName("#define MsiProvideComponent MsiProvideComponentW")]
    public static delegate*<ushort*, ushort*, ushort*, uint, ushort*, uint*, uint> MsiProvideComponent => &MsiProvideComponentW;

    [NativeTypeName("#define MsiProvideQualifiedComponent MsiProvideQualifiedComponentW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint*, uint> MsiProvideQualifiedComponent => &MsiProvideQualifiedComponentW;

    [NativeTypeName("#define MsiProvideQualifiedComponentEx MsiProvideQualifiedComponentExW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint, uint, ushort*, uint*, uint> MsiProvideQualifiedComponentEx => &MsiProvideQualifiedComponentExW;

    [NativeTypeName("#define MsiGetComponentPath MsiGetComponentPathW")]
    public static delegate*<ushort*, ushort*, ushort*, uint*, INSTALLSTATE> MsiGetComponentPath => &MsiGetComponentPathW;

    [NativeTypeName("#define MsiGetComponentPathEx MsiGetComponentPathExW")]
    public static delegate*<ushort*, ushort*, ushort*, MSIINSTALLCONTEXT, ushort*, uint*, INSTALLSTATE> MsiGetComponentPathEx => &MsiGetComponentPathExW;

    [NativeTypeName("#define MSIASSEMBLYINFO_NETASSEMBLY 0")]
    public const int MSIASSEMBLYINFO_NETASSEMBLY = 0;
    [NativeTypeName("#define MSIASSEMBLYINFO_WIN32ASSEMBLY 1")]
    public const int MSIASSEMBLYINFO_WIN32ASSEMBLY = 1;
    [NativeTypeName("#define MsiProvideAssembly MsiProvideAssemblyW")]
    public static delegate*<ushort*, ushort*, uint, uint, ushort*, uint*, uint> MsiProvideAssembly => &MsiProvideAssemblyW;

    [NativeTypeName("#define MsiQueryComponentState MsiQueryComponentStateW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, ushort*, INSTALLSTATE*, uint> MsiQueryComponentState => &MsiQueryComponentStateW;

    [NativeTypeName("#define MsiEnumProducts MsiEnumProductsW")]
    public static delegate*<uint, ushort*, uint> MsiEnumProducts => &MsiEnumProductsW;

    [NativeTypeName("#define MsiEnumProductsEx MsiEnumProductsExW")]
    public static delegate*<ushort*, ushort*, uint, uint, ushort*, MSIINSTALLCONTEXT*, ushort*, uint*, uint> MsiEnumProductsEx => &MsiEnumProductsExW;

    [NativeTypeName("#define MsiEnumRelatedProducts MsiEnumRelatedProductsW")]
    public static delegate*<ushort*, uint, uint, ushort*, uint> MsiEnumRelatedProducts => &MsiEnumRelatedProductsW;

    [NativeTypeName("#define MsiEnumFeatures MsiEnumFeaturesW")]
    public static delegate*<ushort*, uint, ushort*, ushort*, uint> MsiEnumFeatures => &MsiEnumFeaturesW;

    [NativeTypeName("#define MsiEnumComponents MsiEnumComponentsW")]
    public static delegate*<uint, ushort*, uint> MsiEnumComponents => &MsiEnumComponentsW;

    [NativeTypeName("#define MsiEnumComponentsEx MsiEnumComponentsExW")]
    public static delegate*<ushort*, uint, uint, ushort*, MSIINSTALLCONTEXT*, ushort*, uint*, uint> MsiEnumComponentsEx => &MsiEnumComponentsExW;

    [NativeTypeName("#define MsiEnumClients MsiEnumClientsW")]
    public static delegate*<ushort*, uint, ushort*, uint> MsiEnumClients => &MsiEnumClientsW;

    [NativeTypeName("#define MsiEnumClientsEx MsiEnumClientsExW")]
    public static delegate*<ushort*, ushort*, uint, uint, ushort*, MSIINSTALLCONTEXT*, ushort*, uint*, uint> MsiEnumClientsEx => &MsiEnumClientsExW;

    [NativeTypeName("#define MsiEnumComponentQualifiers MsiEnumComponentQualifiersW")]
    public static delegate*<ushort*, uint, ushort*, uint*, ushort*, uint*, uint> MsiEnumComponentQualifiers => &MsiEnumComponentQualifiersW;

    [NativeTypeName("#define MsiOpenProduct MsiOpenProductW")]
    public static delegate*<ushort*, MSIHANDLE*, uint> MsiOpenProduct => &MsiOpenProductW;

    [NativeTypeName("#define MsiOpenPackage MsiOpenPackageW")]
    public static delegate*<ushort*, MSIHANDLE*, uint> MsiOpenPackage => &MsiOpenPackageW;

    [NativeTypeName("#define MsiOpenPackageEx MsiOpenPackageExW")]
    public static delegate*<ushort*, uint, MSIHANDLE*, uint> MsiOpenPackageEx => &MsiOpenPackageExW;

    [NativeTypeName("#define MsiGetPatchFileList MsiGetPatchFileListW")]
    public static delegate*<ushort*, ushort*, uint*, MSIHANDLE**, uint> MsiGetPatchFileList => &MsiGetPatchFileListW;

    [NativeTypeName("#define MsiGetProductProperty MsiGetProductPropertyW")]
    public static delegate*<MSIHANDLE, ushort*, ushort*, uint*, uint> MsiGetProductProperty => &MsiGetProductPropertyW;

    [NativeTypeName("#define MsiVerifyPackage MsiVerifyPackageW")]
    public static delegate*<ushort*, uint> MsiVerifyPackage => &MsiVerifyPackageW;

    [NativeTypeName("#define MsiGetFeatureInfo MsiGetFeatureInfoW")]
    public static delegate*<MSIHANDLE, ushort*, uint*, ushort*, uint*, ushort*, uint*, uint> MsiGetFeatureInfo => &MsiGetFeatureInfoW;

    [NativeTypeName("#define MsiInstallMissingComponent MsiInstallMissingComponentW")]
    public static delegate*<ushort*, ushort*, INSTALLSTATE, uint> MsiInstallMissingComponent => &MsiInstallMissingComponentW;

    [NativeTypeName("#define MsiInstallMissingFile MsiInstallMissingFileW")]
    public static delegate*<ushort*, ushort*, uint> MsiInstallMissingFile => &MsiInstallMissingFileW;

    [NativeTypeName("#define MsiLocateComponent MsiLocateComponentW")]
    public static delegate*<ushort*, ushort*, uint*, INSTALLSTATE> MsiLocateComponent => &MsiLocateComponentW;

    [NativeTypeName("#define MsiSourceListClearAll MsiSourceListClearAllW")]
    public static delegate*<ushort*, ushort*, uint, uint> MsiSourceListClearAll => &MsiSourceListClearAllW;

    [NativeTypeName("#define MsiSourceListAddSource MsiSourceListAddSourceW")]
    public static delegate*<ushort*, ushort*, uint, ushort*, uint> MsiSourceListAddSource => &MsiSourceListAddSourceW;

    [NativeTypeName("#define MsiSourceListForceResolution MsiSourceListForceResolutionW")]
    public static delegate*<ushort*, ushort*, uint, uint> MsiSourceListForceResolution => &MsiSourceListForceResolutionW;

    [NativeTypeName("#define MsiSourceListAddSourceEx MsiSourceListAddSourceExW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, ushort*, uint, uint> MsiSourceListAddSourceEx => &MsiSourceListAddSourceExW;

    [NativeTypeName("#define MsiSourceListAddMediaDisk MsiSourceListAddMediaDiskW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint, ushort*, ushort*, uint> MsiSourceListAddMediaDisk => &MsiSourceListAddMediaDiskW;

    [NativeTypeName("#define MsiSourceListClearSource MsiSourceListClearSourceW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, ushort*, uint> MsiSourceListClearSource => &MsiSourceListClearSourceW;

    [NativeTypeName("#define MsiSourceListClearMediaDisk MsiSourceListClearMediaDiskW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint, uint> MsiSourceListClearMediaDisk => &MsiSourceListClearMediaDiskW;

    [NativeTypeName("#define MsiSourceListClearAllEx MsiSourceListClearAllExW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint> MsiSourceListClearAllEx => &MsiSourceListClearAllExW;

    [NativeTypeName("#define MsiSourceListForceResolutionEx MsiSourceListForceResolutionExW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint> MsiSourceListForceResolutionEx => &MsiSourceListForceResolutionExW;

    [NativeTypeName("#define MsiSourceListSetInfo MsiSourceListSetInfoW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, ushort*, ushort*, uint> MsiSourceListSetInfo => &MsiSourceListSetInfoW;

    [NativeTypeName("#define MsiSourceListGetInfo MsiSourceListGetInfoW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, ushort*, ushort*, uint*, uint> MsiSourceListGetInfo => &MsiSourceListGetInfoW;

    [NativeTypeName("#define MsiSourceListEnumSources MsiSourceListEnumSourcesW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint, ushort*, uint*, uint> MsiSourceListEnumSources => &MsiSourceListEnumSourcesW;

    [NativeTypeName("#define MsiSourceListEnumMediaDisks MsiSourceListEnumMediaDisksW")]
    public static delegate*<ushort*, ushort*, MSIINSTALLCONTEXT, uint, uint, uint*, ushort*, uint*, ushort*, uint*, uint> MsiSourceListEnumMediaDisks => &MsiSourceListEnumMediaDisksW;

    [NativeTypeName("#define MsiGetFileVersion MsiGetFileVersionW")]
    public static delegate*<ushort*, ushort*, uint*, ushort*, uint*, uint> MsiGetFileVersion => &MsiGetFileVersionW;

    [NativeTypeName("#define MsiGetFileHash MsiGetFileHashW")]
    public static delegate*<ushort*, uint, MSIFILEHASHINFO*, uint> MsiGetFileHash => &MsiGetFileHashW;

    [NativeTypeName("#define MsiGetFileSignatureInformation MsiGetFileSignatureInformationW")]
    public static delegate*<ushort*, uint, CERT_CONTEXT**, byte*, uint*, HRESULT> MsiGetFileSignatureInformation => &MsiGetFileSignatureInformationW;

    [NativeTypeName("#define MSI_INVALID_HASH_IS_FATAL 0x1")]
    public const int MSI_INVALID_HASH_IS_FATAL = 0x1;
    [NativeTypeName("#define MsiGetShortcutTarget MsiGetShortcutTargetW")]
    public static delegate*<ushort*, ushort*, ushort*, ushort*, uint> MsiGetShortcutTarget => &MsiGetShortcutTargetW;

    [NativeTypeName("#define MsiIsProductElevated MsiIsProductElevatedW")]
    public static delegate*<ushort*, BOOL*, uint> MsiIsProductElevated => &MsiIsProductElevatedW;

    [NativeTypeName("#define MsiNotifySidChange MsiNotifySidChangeW")]
    public static delegate*<ushort*, ushort*, uint> MsiNotifySidChange => &MsiNotifySidChangeW;

    [NativeTypeName("#define MsiBeginTransaction MsiBeginTransactionW")]
    public static delegate*<ushort*, uint, MSIHANDLE*, HANDLE*, uint> MsiBeginTransaction => &MsiBeginTransactionW;
}