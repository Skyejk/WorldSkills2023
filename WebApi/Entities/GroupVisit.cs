//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupVisit
    {
        public int ID { get; set; }
        public int VisitorID { get; set; }
        public int GroupID { get; set; }
        public int InformForThePassID { get; set; }
        public int HostPartyID { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual HostParty HostParty { get; set; }
        public virtual InformForThePass InformForThePass { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
