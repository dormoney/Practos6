//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practos_6.youyou
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoyaltyPrograms
    {
        public int ProgramID { get; set; }
        public Nullable<int> AudienceID { get; set; }
        public Nullable<decimal> DiscountPercentage { get; set; }
        public Nullable<int> BonusPoints { get; set; }
    
        public virtual Audience Audience { get; set; }
    }
}
