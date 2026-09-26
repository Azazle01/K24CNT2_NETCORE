using System;
using System.Collections.Generic;

namespace NguyenXuanTruong2410900081_exam.Models;

public partial class NxtEmployee
{
    public long Id { get; set; }

    public string? NxtName { get; set; }

    public bool? NxtGender { get; set; }

    public DateOnly? NxtBirthday { get; set; }

    public string? NxtEmail { get; set; }

    public string? NxtPhone { get; set; }

    public bool? NxtActive { get; set; }
}
