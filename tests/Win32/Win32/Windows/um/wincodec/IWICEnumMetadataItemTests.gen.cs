// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IWICEnumMetadataItem"/> struct.</summary>
public static unsafe partial class IWICEnumMetadataItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICEnumMetadataItem"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICEnumMetadataItem).GUID, Is.EqualTo(IID_IWICEnumMetadataItem));
    }

    /// <summary>Validates that the <see cref = "IWICEnumMetadataItem"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IWICEnumMetadataItem>(),
            Is.EqualTo(sizeof(IWICEnumMetadataItem))
        );
    }

    /// <summary>Validates that the <see cref = "IWICEnumMetadataItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICEnumMetadataItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICEnumMetadataItem"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICEnumMetadataItem), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICEnumMetadataItem), Is.EqualTo(4));
        }
    }
}
