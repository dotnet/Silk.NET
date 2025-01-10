// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IHdmiDisplayInformation"/> struct.</summary>
public static unsafe partial class IHdmiDisplayInformationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHdmiDisplayInformation"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHdmiDisplayInformation).GUID, Is.EqualTo(IID_IHdmiDisplayInformation));
    }

    /// <summary>Validates that the <see cref = "IHdmiDisplayInformation"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IHdmiDisplayInformation>(),
            Is.EqualTo(sizeof(IHdmiDisplayInformation))
        );
    }

    /// <summary>Validates that the <see cref = "IHdmiDisplayInformation"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHdmiDisplayInformation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHdmiDisplayInformation"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHdmiDisplayInformation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHdmiDisplayInformation), Is.EqualTo(4));
        }
    }
}
