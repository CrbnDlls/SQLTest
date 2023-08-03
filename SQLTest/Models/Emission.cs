using System;
using System.Collections.Generic;

namespace SQLTest.Models;

public partial class Emission
{
    public int IdEmission { get; set; }

    public int IdSource { get; set; }

    public decimal Count { get; set; }

    public string Text { get; set; } = null!;

    public DateTime Date { get; set; }

    public virtual Source IdSourceNavigation { get; set; } = null!;
}
