// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_INSTALLWIZARD_DATA
{
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("HPROPSHEETPAGE[20]")]
    public _DynamicPages_e__FixedBuffer DynamicPages;

    [NativeTypeName("DWORD")]
    public uint NumDynamicPages;

    [NativeTypeName("DWORD")]
    public uint DynamicPageFlags;

    [NativeTypeName("DWORD")]
    public uint PrivateFlags;
    public LPARAM PrivateData;
    public HWND hwndWizardDlg;

    public unsafe partial struct _DynamicPages_e__FixedBuffer
    {
        public HPROPSHEETPAGE e0;
        public HPROPSHEETPAGE e1;
        public HPROPSHEETPAGE e2;
        public HPROPSHEETPAGE e3;
        public HPROPSHEETPAGE e4;
        public HPROPSHEETPAGE e5;
        public HPROPSHEETPAGE e6;
        public HPROPSHEETPAGE e7;
        public HPROPSHEETPAGE e8;
        public HPROPSHEETPAGE e9;
        public HPROPSHEETPAGE e10;
        public HPROPSHEETPAGE e11;
        public HPROPSHEETPAGE e12;
        public HPROPSHEETPAGE e13;
        public HPROPSHEETPAGE e14;
        public HPROPSHEETPAGE e15;
        public HPROPSHEETPAGE e16;
        public HPROPSHEETPAGE e17;
        public HPROPSHEETPAGE e18;
        public HPROPSHEETPAGE e19;
        public ref HPROPSHEETPAGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (HPROPSHEETPAGE* pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}
