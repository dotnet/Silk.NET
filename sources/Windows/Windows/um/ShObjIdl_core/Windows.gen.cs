// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSimpleIDListFromPath"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHSimpleIDListFromPath([NativeTypeName("PCWSTR")] ushort* pszPath);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromIDList"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromParsingName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemWithParent"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemWithParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppvItem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromRelativeName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromRelativeName(IShellItem* psiParent, [NativeTypeName("PCWSTR")] ushort* pszName, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemInKnownFolder"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemInKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfid, [NativeTypeName("DWORD")] uint dwKFFlags, [NativeTypeName("PCWSTR")] ushort* pszItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetIDListFromObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetIDListFromObject(IUnknown* punk, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetItemFromObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetItemFromObject(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPropertyStoreFromIDList"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPropertyStoreFromParsingName"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetNameFromIDList"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetNameFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, SIGDN sigdnName, [NativeTypeName("PWSTR *")] ushort** ppszName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetItemFromDataObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetItemFromDataObject(IDataObject* pdtobj, DATAOBJ_GET_ITEM_FLAGS dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArray"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psf, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidl, IShellItemArray** ppsiItemArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromDataObject"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromDataObject(IDataObject* pdo, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromIDLists"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromIDLists(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** rgpidl, IShellItemArray** ppsiItemArray);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromShellItem"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromShellItem(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeIDListArray"]/*'/>
    public static void FreeIDListArray([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidls, uint cItems)
    {
        uint i;
        for (i = 0; i < cItems; i++)
        {
            CoTaskMemFree(unchecked((void*)(ppidls[i])));
        }

        CoTaskMemFree(ppidls);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateAssociationRegistration"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateAssociationRegistration([NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeKnownFolderDefinitionFields"]/*'/>
    public static void FreeKnownFolderDefinitionFields(KNOWNFOLDER_DEFINITION* pKFD)
    {
        CoTaskMemFree(pKFD->pszName);
        CoTaskMemFree(pKFD->pszDescription);
        CoTaskMemFree(pKFD->pszRelativePath);
        CoTaskMemFree(pKFD->pszParsingName);
        CoTaskMemFree(pKFD->pszTooltip);
        CoTaskMemFree(pKFD->pszLocalizedName);
        CoTaskMemFree(pKFD->pszIcon);
        CoTaskMemFree(pKFD->pszSecurity);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDefaultExtractIcon"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultExtractIcon([NativeTypeName("const IID &")] Guid* riid, void** ppv);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCurrentProcessExplicitAppUserModelID"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SetCurrentProcessExplicitAppUserModelID([NativeTypeName("PCWSTR")] ushort* AppID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcessExplicitAppUserModelID"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT GetCurrentProcessExplicitAppUserModelID([NativeTypeName("PWSTR *")] ushort** AppID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetTemporaryPropertyForItem"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetTemporaryPropertyForItem"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHShowManageLibraryUI"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHShowManageLibraryUI(IShellItem* psiLibrary, HWND hwndOwner, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszInstruction, LIBRARYMANAGEDIALOGOPTIONS lmdOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHResolveLibrary"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHResolveLibrary(IShellItem* psiLibrary);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAssocEnumHandlers"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAssocEnumHandlers([NativeTypeName("PCWSTR")] ushort* pszExtra, ASSOC_FILTER afFilter, IEnumAssocHandlers** ppEnumHandler);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAssocEnumHandlersForProtocolByApplication"]/*'/>
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAssocEnumHandlersForProtocolByApplication([NativeTypeName("PCWSTR")] ushort* protocol, [NativeTypeName("const IID &")] Guid* riid, void** enumHandlers);
    [NativeTypeName("#define CMDSTR_NEWFOLDERA \"NewFolder\"")]
    public static ReadOnlySpan<byte> CMDSTR_NEWFOLDERA => "NewFolder"u8;

    [NativeTypeName("#define CMDSTR_VIEWLISTA \"ViewList\"")]
    public static ReadOnlySpan<byte> CMDSTR_VIEWLISTA => "ViewList"u8;

    [NativeTypeName("#define CMDSTR_VIEWDETAILSA \"ViewDetails\"")]
    public static ReadOnlySpan<byte> CMDSTR_VIEWDETAILSA => "ViewDetails"u8;

    [NativeTypeName("#define CMDSTR_NEWFOLDERW L\"NewFolder\"")]
    public const string CMDSTR_NEWFOLDERW = "NewFolder";
    [NativeTypeName("#define CMDSTR_VIEWLISTW L\"ViewList\"")]
    public const string CMDSTR_VIEWLISTW = "ViewList";
    [NativeTypeName("#define CMDSTR_VIEWDETAILSW L\"ViewDetails\"")]
    public const string CMDSTR_VIEWDETAILSW = "ViewDetails";
    [NativeTypeName("#define CMDSTR_NEWFOLDER CMDSTR_NEWFOLDERW")]
    public const string CMDSTR_NEWFOLDER = "NewFolder";
    [NativeTypeName("#define CMDSTR_VIEWLIST CMDSTR_VIEWLISTW")]
    public const string CMDSTR_VIEWLIST = "ViewList";
    [NativeTypeName("#define CMDSTR_VIEWDETAILS CMDSTR_VIEWDETAILSW")]
    public const string CMDSTR_VIEWDETAILS = "ViewDetails";
    [NativeTypeName("#define IRTIR_TASK_NOT_RUNNING 0")]
    public const int IRTIR_TASK_NOT_RUNNING = 0;
    [NativeTypeName("#define IRTIR_TASK_RUNNING 1")]
    public const int IRTIR_TASK_RUNNING = 1;
    [NativeTypeName("#define IRTIR_TASK_SUSPENDED 2")]
    public const int IRTIR_TASK_SUSPENDED = 2;
    [NativeTypeName("#define IRTIR_TASK_PENDING 3")]
    public const int IRTIR_TASK_PENDING = 3;
    [NativeTypeName("#define IRTIR_TASK_FINISHED 4")]
    public const int IRTIR_TASK_FINISHED = 4;
    [NativeTypeName("#define ITSAT_DEFAULT_LPARAM ((DWORD_PTR)-1)")]
    public static nuint ITSAT_DEFAULT_LPARAM => unchecked((nuint)(-1));

    [NativeTypeName("#define ITSAT_DEFAULT_PRIORITY 0x10000000")]
    public const int ITSAT_DEFAULT_PRIORITY = 0x10000000;
    [NativeTypeName("#define ITSAT_MAX_PRIORITY 0x7fffffff")]
    public const int ITSAT_MAX_PRIORITY = 0x7fffffff;
    [NativeTypeName("#define ITSAT_MIN_PRIORITY 0x00000000")]
    public const int ITSAT_MIN_PRIORITY = 0x00000000;
    [NativeTypeName("#define ITSSFLAG_COMPLETE_ON_DESTROY 0x0000")]
    public const int ITSSFLAG_COMPLETE_ON_DESTROY = 0x0000;
    [NativeTypeName("#define ITSSFLAG_KILL_ON_DESTROY 0x0001")]
    public const int ITSSFLAG_KILL_ON_DESTROY = 0x0001;
    [NativeTypeName("#define ITSSFLAG_FLAGS_MASK 0x0003")]
    public const int ITSSFLAG_FLAGS_MASK = 0x0003;
    [NativeTypeName("#define ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT (10*1000)")]
    public const int ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT = (10 * 1000);
    [NativeTypeName("#define ITSS_THREAD_TERMINATE_TIMEOUT (INFINITE)")]
    public const uint ITSS_THREAD_TERMINATE_TIMEOUT = (0xFFFFFFFF);
    [NativeTypeName("#define ITSS_THREAD_TIMEOUT_NO_CHANGE (INFINITE - 1)")]
    public const uint ITSS_THREAD_TIMEOUT_NO_CHANGE = (0xFFFFFFFF - 1);
    [NativeTypeName("#define SHCIDS_ALLFIELDS 0x80000000L")]
    public const uint SHCIDS_ALLFIELDS = 0x80000000;
    [NativeTypeName("#define SHCIDS_CANONICALONLY 0x10000000L")]
    public const int SHCIDS_CANONICALONLY = 0x10000000;
    [NativeTypeName("#define SHCIDS_BITMASK 0xFFFF0000L")]
    public const uint SHCIDS_BITMASK = 0xFFFF0000;
    [NativeTypeName("#define SHCIDS_COLUMNMASK 0x0000FFFFL")]
    public const int SHCIDS_COLUMNMASK = 0x0000FFFF;
    [NativeTypeName("#define CONFLICT_RESOLUTION_CLSID_KEY L\"ConflictResolutionCLSID\"")]
    public const string CONFLICT_RESOLUTION_CLSID_KEY = "ConflictResolutionCLSID";
    [NativeTypeName("#define BIND_INTERRUPTABLE 0xFFFFFFFF")]
    public const uint BIND_INTERRUPTABLE = 0xFFFFFFFF;
    [NativeTypeName("#define SVSI_NOSTATECHANGE ((UINT)0x80000000)")]
    public const uint SVSI_NOSTATECHANGE = ((uint)(0x80000000));
    [NativeTypeName("#define SV2GV_CURRENTVIEW ((UINT)-1)")]
    public const uint SV2GV_CURRENTVIEW = unchecked((uint)(-1));
    [NativeTypeName("#define SV2GV_DEFAULTVIEW ((UINT)-2)")]
    public const uint SV2GV_DEFAULTVIEW = unchecked((uint)(-2));
    [NativeTypeName("#define CDBOSC_SETFOCUS 0x00000000")]
    public const int CDBOSC_SETFOCUS = 0x00000000;
    [NativeTypeName("#define CDBOSC_KILLFOCUS 0x00000001")]
    public const int CDBOSC_KILLFOCUS = 0x00000001;
    [NativeTypeName("#define CDBOSC_SELCHANGE 0x00000002")]
    public const int CDBOSC_SELCHANGE = 0x00000002;
    [NativeTypeName("#define CDBOSC_RENAME 0x00000003")]
    public const int CDBOSC_RENAME = 0x00000003;
    [NativeTypeName("#define CDBOSC_STATECHANGE 0x00000004")]
    public const int CDBOSC_STATECHANGE = 0x00000004;
    [NativeTypeName("#define CDB2N_CONTEXTMENU_DONE 0x00000001")]
    public const int CDB2N_CONTEXTMENU_DONE = 0x00000001;
    [NativeTypeName("#define CDB2N_CONTEXTMENU_START 0x00000002")]
    public const int CDB2N_CONTEXTMENU_START = 0x00000002;
    [NativeTypeName("#define CDB2GVF_SHOWALLFILES 0x00000001")]
    public const int CDB2GVF_SHOWALLFILES = 0x00000001;
    [NativeTypeName("#define CDB2GVF_ISFILESAVE 0x00000002")]
    public const int CDB2GVF_ISFILESAVE = 0x00000002;
    [NativeTypeName("#define CDB2GVF_ALLOWPREVIEWPANE 0x00000004")]
    public const int CDB2GVF_ALLOWPREVIEWPANE = 0x00000004;
    [NativeTypeName("#define CDB2GVF_NOSELECTVERB 0x00000008")]
    public const int CDB2GVF_NOSELECTVERB = 0x00000008;
    [NativeTypeName("#define CDB2GVF_NOINCLUDEITEM 0x00000010")]
    public const int CDB2GVF_NOINCLUDEITEM = 0x00000010;
    [NativeTypeName("#define CDB2GVF_ISFOLDERPICKER 0x00000020")]
    public const int CDB2GVF_ISFOLDERPICKER = 0x00000020;
    [NativeTypeName("#define CDB2GVF_ADDSHIELD 0x00000040")]
    public const int CDB2GVF_ADDSHIELD = 0x00000040;
    [NativeTypeName("#define FCW_STATUS 0x0001")]
    public const int FCW_STATUS = 0x0001;
    [NativeTypeName("#define FCW_TOOLBAR 0x0002")]
    public const int FCW_TOOLBAR = 0x0002;
    [NativeTypeName("#define FCW_TREE 0x0003")]
    public const int FCW_TREE = 0x0003;
    [NativeTypeName("#define FCW_INTERNETBAR 0x0006")]
    public const int FCW_INTERNETBAR = 0x0006;
    [NativeTypeName("#define FCW_PROGRESS 0x0008")]
    public const int FCW_PROGRESS = 0x0008;
    [NativeTypeName("#define FCT_MERGE 0x0001")]
    public const int FCT_MERGE = 0x0001;
    [NativeTypeName("#define FCT_CONFIGABLE 0x0002")]
    public const int FCT_CONFIGABLE = 0x0002;
    [NativeTypeName("#define FCT_ADDTOEND 0x0004")]
    public const int FCT_ADDTOEND = 0x0004;
    [NativeTypeName("#define IEI_PRIORITY_MAX ITSAT_MAX_PRIORITY")]
    public const int IEI_PRIORITY_MAX = 0x7fffffff;
    [NativeTypeName("#define IEI_PRIORITY_MIN ITSAT_MIN_PRIORITY")]
    public const int IEI_PRIORITY_MIN = 0x00000000;
    [NativeTypeName("#define IEIT_PRIORITY_NORMAL ITSAT_DEFAULT_PRIORITY")]
    public const int IEIT_PRIORITY_NORMAL = 0x10000000;
    [NativeTypeName("#define DBIM_MINSIZE 0x0001")]
    public const int DBIM_MINSIZE = 0x0001;
    [NativeTypeName("#define DBIM_MAXSIZE 0x0002")]
    public const int DBIM_MAXSIZE = 0x0002;
    [NativeTypeName("#define DBIM_INTEGRAL 0x0004")]
    public const int DBIM_INTEGRAL = 0x0004;
    [NativeTypeName("#define DBIM_ACTUAL 0x0008")]
    public const int DBIM_ACTUAL = 0x0008;
    [NativeTypeName("#define DBIM_TITLE 0x0010")]
    public const int DBIM_TITLE = 0x0010;
    [NativeTypeName("#define DBIM_MODEFLAGS 0x0020")]
    public const int DBIM_MODEFLAGS = 0x0020;
    [NativeTypeName("#define DBIM_BKCOLOR 0x0040")]
    public const int DBIM_BKCOLOR = 0x0040;
    [NativeTypeName("#define DBIF_VIEWMODE_NORMAL 0x0000")]
    public const int DBIF_VIEWMODE_NORMAL = 0x0000;
    [NativeTypeName("#define DBIF_VIEWMODE_VERTICAL 0x0001")]
    public const int DBIF_VIEWMODE_VERTICAL = 0x0001;
    [NativeTypeName("#define DBIF_VIEWMODE_FLOATING 0x0002")]
    public const int DBIF_VIEWMODE_FLOATING = 0x0002;
    [NativeTypeName("#define DBIF_VIEWMODE_TRANSPARENT 0x0004")]
    public const int DBIF_VIEWMODE_TRANSPARENT = 0x0004;
    [NativeTypeName("#define DBPC_SELECTFIRST (DWORD)-1")]
    public const uint DBPC_SELECTFIRST = unchecked((uint)(-1));
    [NativeTypeName("#define DBPC_SELECTLAST (DWORD)-2")]
    public const uint DBPC_SELECTLAST = unchecked((uint)(-2));
    [NativeTypeName("#define CGID_DeskBand IID_IDeskBand")]
    public static ref readonly Guid CGID_DeskBand => ref IID_IDeskBand;

    [NativeTypeName("#define THBN_CLICKED 0x1800")]
    public const int THBN_CLICKED = 0x1800;
    [NativeTypeName("#define FreeIDListArrayFull FreeIDListArray")]
    public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayFull => &FreeIDListArray;

    [NativeTypeName("#define FreeIDListArrayChild FreeIDListArray")]
    public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayChild => &FreeIDListArray;

    [NativeTypeName("#define BSIM_STATE 0x00000001")]
    public const int BSIM_STATE = 0x00000001;
    [NativeTypeName("#define BSIM_STYLE 0x00000002")]
    public const int BSIM_STYLE = 0x00000002;
    [NativeTypeName("#define BSSF_VISIBLE 0x00000001")]
    public const int BSSF_VISIBLE = 0x00000001;
    [NativeTypeName("#define BSSF_NOTITLE 0x00000002")]
    public const int BSSF_NOTITLE = 0x00000002;
    [NativeTypeName("#define BSSF_UNDELETEABLE 0x00001000")]
    public const int BSSF_UNDELETEABLE = 0x00001000;
    [NativeTypeName("#define CGID_BandSite IID_IBandSite")]
    public static ref readonly Guid CGID_BandSite => ref IID_IBandSite;

    [NativeTypeName("#define SMDM_SHELLFOLDER 0x00000001")]
    public const int SMDM_SHELLFOLDER = 0x00000001;
    [NativeTypeName("#define SMDM_HMENU 0x00000002")]
    public const int SMDM_HMENU = 0x00000002;
    [NativeTypeName("#define SMDM_TOOLBAR 0x00000004")]
    public const int SMDM_TOOLBAR = 0x00000004;
    [NativeTypeName("#define SMAE_EXPANDED 0x00000001")]
    public const int SMAE_EXPANDED = 0x00000001;
    [NativeTypeName("#define SMAE_CONTRACTED 0x00000002")]
    public const int SMAE_CONTRACTED = 0x00000002;
    [NativeTypeName("#define SMAE_USER 0x00000004")]
    public const int SMAE_USER = 0x00000004;
    [NativeTypeName("#define SMAE_VALID 0x00000007")]
    public const int SMAE_VALID = 0x00000007;
    [NativeTypeName("#define SMINIT_DEFAULT 0x00000000")]
    public const int SMINIT_DEFAULT = 0x00000000;
    [NativeTypeName("#define SMINIT_RESTRICT_DRAGDROP 0x00000002")]
    public const int SMINIT_RESTRICT_DRAGDROP = 0x00000002;
    [NativeTypeName("#define SMINIT_TOPLEVEL 0x00000004")]
    public const int SMINIT_TOPLEVEL = 0x00000004;
    [NativeTypeName("#define SMINIT_CACHED 0x00000010")]
    public const int SMINIT_CACHED = 0x00000010;
    [NativeTypeName("#define SMINIT_AUTOEXPAND 0x00000100")]
    public const int SMINIT_AUTOEXPAND = 0x00000100;
    [NativeTypeName("#define SMINIT_AUTOTOOLTIP 0x00000200")]
    public const int SMINIT_AUTOTOOLTIP = 0x00000200;
    [NativeTypeName("#define SMINIT_DROPONCONTAINER 0x00000400")]
    public const int SMINIT_DROPONCONTAINER = 0x00000400;
    [NativeTypeName("#define SMINIT_VERTICAL 0x10000000")]
    public const int SMINIT_VERTICAL = 0x10000000;
    [NativeTypeName("#define SMINIT_HORIZONTAL 0x20000000")]
    public const int SMINIT_HORIZONTAL = 0x20000000;
    [NativeTypeName("#define ANCESTORDEFAULT (UINT)-1")]
    public const uint ANCESTORDEFAULT = unchecked((uint)(-1));
    [NativeTypeName("#define SMSET_TOP 0x10000000")]
    public const int SMSET_TOP = 0x10000000;
    [NativeTypeName("#define SMSET_BOTTOM 0x20000000")]
    public const int SMSET_BOTTOM = 0x20000000;
    [NativeTypeName("#define SMSET_DONTOWN 0x00000001")]
    public const int SMSET_DONTOWN = 0x00000001;
    [NativeTypeName("#define SMINV_REFRESH 0x00000001")]
    public const int SMINV_REFRESH = 0x00000001;
    [NativeTypeName("#define SMINV_ID 0x00000008")]
    public const int SMINV_ID = 0x00000008;
    [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP_MULTI L\"HUG\"")]
    public const string HOMEGROUP_SECURITY_GROUP_MULTI = "HUG";
    [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP L\"HomeUsers\"")]
    public const string HOMEGROUP_SECURITY_GROUP = "HomeUsers";
    [NativeTypeName("#define PROP_CONTRACT_DELEGATE L\"ContractDelegate\"")]
    public const string PROP_CONTRACT_DELEGATE = "ContractDelegate";
    [NativeTypeName("#define ISIOI_ICONFILE 0x00000001")]
    public const int ISIOI_ICONFILE = 0x00000001;
    [NativeTypeName("#define ISIOI_ICONINDEX 0x00000002")]
    public const int ISIOI_ICONINDEX = 0x00000002;
}