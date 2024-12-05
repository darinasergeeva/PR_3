using System;
using System.Collections.Generic;

namespace PR_3;

public partial class Partner
{
    public int Id { get; set; }

    public short IdPartnerType { get; set; }

    public string NamePartner { get; set; } = null!;

    public string LegalAddress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string NameOfDirector { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short Rating { get; set; }

    public virtual PartnerType IdPartnerTypeNavigation { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
