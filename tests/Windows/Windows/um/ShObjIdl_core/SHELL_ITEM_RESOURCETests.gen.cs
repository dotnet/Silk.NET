// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SHELL_ITEM_RESOURCE"/> struct.</summary>
public static unsafe partial class SHELL_ITEM_RESOURCETests
{
    /// <summary>Validates that the <see cref = "SHELL_ITEM_RESOURCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHELL_ITEM_RESOURCE>(), Is.EqualTo(sizeof(SHELL_ITEM_RESOURCE)));
    }

    /// <summary>Validates that the <see cref = "SHELL_ITEM_RESOURCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHELL_ITEM_RESOURCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SHELL_ITEM_RESOURCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SHELL_ITEM_RESOURCE), Is.EqualTo(536));
    }
}