// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.contacts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContactConnectedServiceAccount"/> struct.</summary>
public static unsafe partial class IContactConnectedServiceAccountTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContactConnectedServiceAccount"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IContactConnectedServiceAccount).GUID,
            Is.EqualTo(IID_IContactConnectedServiceAccount)
        );
    }

    /// <summary>Validates that the <see cref = "IContactConnectedServiceAccount"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IContactConnectedServiceAccount>(),
            Is.EqualTo(sizeof(IContactConnectedServiceAccount))
        );
    }

    /// <summary>Validates that the <see cref = "IContactConnectedServiceAccount"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactConnectedServiceAccount).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContactConnectedServiceAccount"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactConnectedServiceAccount), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactConnectedServiceAccount), Is.EqualTo(4));
        }
    }
}
