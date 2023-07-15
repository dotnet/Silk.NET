// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IFsiItem"/> struct.</summary>
public static unsafe partial class IFsiItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFsiItem"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFsiItem).GUID, Is.EqualTo(IID_IFsiItem));
    }

    /// <summary>Validates that the <see cref = "IFsiItem"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFsiItem>(), Is.EqualTo(sizeof(IFsiItem)));
    }

    /// <summary>Validates that the <see cref = "IFsiItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFsiItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFsiItem"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFsiItem), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFsiItem), Is.EqualTo(4));
        }
    }
}