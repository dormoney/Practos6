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
    
    public partial class ShowSchedule
    {
        public int ScheduleID { get; set; }
        public Nullable<int> PlayID { get; set; }
        public System.DateTime ShowDate { get; set; }
        public string SeatAvailability { get; set; }
    
        public virtual Plays Plays { get; set; }
    }
}
