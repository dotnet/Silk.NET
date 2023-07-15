// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellLinkDataList"/> struct.</summary>
public static unsafe partial class IShellLinkDataListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellLinkDataList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellLinkDataList).GUID, Is.EqualTo(IID_IShellLinkDataList));
    }

    /// <summary>Validates that the <see cref = "IShellLinkDataList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellLinkDataList>(), Is.EqualTo(sizeof(IShellLinkDataList)));
    }

    /// <summary>Validates that the <see cref = "IShellLinkDataList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellLinkDataList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellLinkDataList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellLinkDataList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellLinkDataList), Is.EqualTo(4));
        }
    }
}