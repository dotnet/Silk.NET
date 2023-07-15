// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellItemResources"/> struct.</summary>
public static unsafe partial class IShellItemResourcesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellItemResources"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellItemResources).GUID, Is.EqualTo(IID_IShellItemResources));
    }

    /// <summary>Validates that the <see cref = "IShellItemResources"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellItemResources>(), Is.EqualTo(sizeof(IShellItemResources)));
    }

    /// <summary>Validates that the <see cref = "IShellItemResources"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellItemResources).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellItemResources"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellItemResources), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellItemResources), Is.EqualTo(4));
        }
    }
}