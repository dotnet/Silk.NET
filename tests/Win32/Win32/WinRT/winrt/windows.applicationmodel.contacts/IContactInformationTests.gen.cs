// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContactInformation"/> struct.</summary>
public static unsafe partial class IContactInformationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactInformation"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContactInformation).GUID, Is.EqualTo(IID_IContactInformation));
    }

    /// <summary>Validates that the <see cref = "IContactInformation"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IContactInformation>(), Is.EqualTo(sizeof(IContactInformation)));
    }

    /// <summary>Validates that the <see cref = "IContactInformation"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactInformation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactInformation"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactInformation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactInformation), Is.EqualTo(4));
        }
    }
}
