// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IH264ProfileIdsStatics"/> struct.</summary>
public static unsafe partial class IH264ProfileIdsStaticsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IH264ProfileIdsStatics"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IH264ProfileIdsStatics).GUID, Is.EqualTo(IID_IH264ProfileIdsStatics));
    }

    /// <summary>Validates that the <see cref = "IH264ProfileIdsStatics"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IH264ProfileIdsStatics>(),
            Is.EqualTo(sizeof(IH264ProfileIdsStatics))
        );
    }

    /// <summary>Validates that the <see cref = "IH264ProfileIdsStatics"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IH264ProfileIdsStatics).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IH264ProfileIdsStatics"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IH264ProfileIdsStatics), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IH264ProfileIdsStatics), Is.EqualTo(4));
        }
    }
}
