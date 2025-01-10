// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IEmailMailboxAction"/> struct.</summary>
public static unsafe partial class IEmailMailboxActionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IEmailMailboxAction"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEmailMailboxAction).GUID, Is.EqualTo(IID_IEmailMailboxAction));
    }

    /// <summary>Validates that the <see cref = "IEmailMailboxAction"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEmailMailboxAction>(), Is.EqualTo(sizeof(IEmailMailboxAction)));
    }

    /// <summary>Validates that the <see cref = "IEmailMailboxAction"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEmailMailboxAction).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IEmailMailboxAction"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEmailMailboxAction), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEmailMailboxAction), Is.EqualTo(4));
        }
    }
}
