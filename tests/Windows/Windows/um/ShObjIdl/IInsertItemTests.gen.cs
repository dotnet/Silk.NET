// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IInsertItem"/> struct.</summary>
public static unsafe partial class IInsertItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IInsertItem"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInsertItem).GUID, Is.EqualTo(IID_IInsertItem));
    }

    /// <summary>Validates that the <see cref = "IInsertItem"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInsertItem>(), Is.EqualTo(sizeof(IInsertItem)));
    }

    /// <summary>Validates that the <see cref = "IInsertItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInsertItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IInsertItem"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInsertItem), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInsertItem), Is.EqualTo(4));
        }
    }
}