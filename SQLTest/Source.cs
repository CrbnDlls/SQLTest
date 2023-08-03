using System;
using System.Collections.Generic;

namespace SQLTest;

public partial class Source
{
    public int IdSource { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Emission> Emissions { get; set; } = new List<Emission>();
}
