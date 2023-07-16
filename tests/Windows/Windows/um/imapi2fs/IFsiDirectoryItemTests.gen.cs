// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IFsiDirectoryItem"/> struct.</summary>
public static unsafe partial class IFsiDirectoryItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFsiDirectoryItem"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFsiDirectoryItem).GUID, Is.EqualTo(IID_IFsiDirectoryItem));
    }

    /// <summary>Validates that the <see cref = "IFsiDirectoryItem"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFsiDirectoryItem>(), Is.EqualTo(sizeof(IFsiDirectoryItem)));
    }

    /// <summary>Validates that the <see cref = "IFsiDirectoryItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFsiDirectoryItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFsiDirectoryItem"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFsiDirectoryItem), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFsiDirectoryItem), Is.EqualTo(4));
        }
    }
}