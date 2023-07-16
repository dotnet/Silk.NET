// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellPropSheetExt"/> struct.</summary>
public static unsafe partial class IShellPropSheetExtTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellPropSheetExt"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellPropSheetExt).GUID, Is.EqualTo(IID_IShellPropSheetExt));
    }

    /// <summary>Validates that the <see cref = "IShellPropSheetExt"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellPropSheetExt>(), Is.EqualTo(sizeof(IShellPropSheetExt)));
    }

    /// <summary>Validates that the <see cref = "IShellPropSheetExt"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellPropSheetExt).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellPropSheetExt"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellPropSheetExt), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellPropSheetExt), Is.EqualTo(4));
        }
    }
}