using System;
using System.Collections.Generic;

namespace NxtLesson10EFDbFirst.Models;

public partial class NxtMember
{
    public long Id { get; set; }

    public string? NxtUserName { get; set; }

    public string? NxtPassword { get; set; }

    public string? NxtFullName { get; set; }

    public string? NxtEmail { get; set; }

    public string? NxtPhone { get; set; }

    public bool? NxtStatus { get; set; }
}
