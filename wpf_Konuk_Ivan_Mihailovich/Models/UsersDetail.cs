using System;
using System.Collections.Generic;

namespace wpf_Konuk_Ivan_Mihailovich.Models;

public partial class UsersDetail
{
    public long Id { get; set; }

    public long Userid { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public virtual User User { get; set; } = null!;
}
